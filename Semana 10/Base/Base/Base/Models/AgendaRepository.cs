using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SQLite;

namespace Base.Models
{
    class AgendaRepository
    {
        private SQLiteConnection con;
        private static AgendaRepository instancia;
        public static AgendaRepository Instancia
        {
            get
            {
                if (instancia == null)
                    throw new Exception("Debe llamar al inicializador, acción detenida");
                return instancia;
            }
        }
        public static void Inicializador(String filename)
        {
            if (filename == null)
            {
                throw new ArgumentException();
            }
            if (instancia != null)
            {
                instancia.con.Close();
            }
            instancia = new AgendaRepository(filename);
        }
        private AgendaRepository(String dbPath)
        {
            con = new SQLiteConnection(dbPath);
            con.CreateTable<Agenda>();
        }
        public string EstadoMensaje;
        public int AddNewAgenda(string linea)
        {
            int result = 0;
            try
            {
                result = con.Insert(new Agenda
                {
                    Linea = linea,
                });
                EstadoMensaje = string.Format("Cantidad filas : {0}", result);
            }
            catch (Exception e)
            { EstadoMensaje = e.Message; }
            return result;
        }
        public IEnumerable<Agenda> GetAllAgendas()
        {
            try
            {
                return con.Table<Agenda>();
            }
            catch (Exception e)
            {
                EstadoMensaje = e.Message;
            }
            return Enumerable.Empty<Agenda>();
        }
    }
}
