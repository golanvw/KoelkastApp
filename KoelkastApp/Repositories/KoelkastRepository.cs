using KoelkastApp.MVVM.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KoelkastApp.Repositories
{
    public class KoelkastRepository
    {
        SQLiteConnection connection;
        public string? statusMessage { get; set; }
        public KoelkastRepository()
        {
            connection = new SQLiteConnection(
                Constants.DatabasePath,
                Constants.flags);
            connection.CreateTable<Koelkast>();
        }

        public void AddOrUpdate(Koelkast koelkast)
        {
            int result = 0;
            try
            {
                if (koelkast.KoelkastId != 0)
                {
                    result = connection.Update(koelkast);
                    statusMessage = $"{result} row(s) updated";
                }
                else
                {
                    result = connection.Insert(koelkast);
                    statusMessage = $"{result} row(s) added";
                }
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }

        public List<Koelkast> GetAll()
        {
            try
            {
                return connection.Table<Koelkast>().ToList();
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public Koelkast? Get(int id)
        {
            try
            {
                return connection.Table<Koelkast>().FirstOrDefault(x => x.KoelkastId == id);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
            return null;
        }

        public void Delete(int koelkastId)
        {
            try
            {
                Koelkast koelkast = Get(koelkastId);
                connection.Delete(koelkast);
            }
            catch (Exception ex)
            {
                statusMessage = $"Error: {ex.Message}";
            }
        }
    }
}
