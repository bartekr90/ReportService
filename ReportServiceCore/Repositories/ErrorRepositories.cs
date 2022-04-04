using ReportService.Core.Domains;
using System;
using System.Collections.Generic;

namespace ReportService.Core.Repositories
{
    public class ErrorRepositories
    {
        public List<Error> GetLastErrors(int intervalInMinutes)
        {
            //pobieranie z bazy danych

            return new List<Error>
            {
                new Error {Message = "błąd test 1", Date = DateTime.Now},
                new Error {Message = "błąd test 2", Date = DateTime.Now},
                new Error {Message = "błąd test 3", Date = DateTime.Now},
                
            };

        }
    }
}
