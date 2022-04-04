using EmailSender;
using ReportService.Core;
using ReportService.Core.Domains;
using System;
using System.Collections.Generic;

namespace ReportService.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            return ;
            var emailReceiver = "nikobelic989wp@gmail.com";

            var htmlEmail = new GenerateHtmlEmail();

            var email = new Email(new EmailParams
            {
                HostSmtp = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                SenderName = "Bartosz Rachwał",
                SenderEmail = "testowymail989@gmail.com",
                SenderEmailPassword = ""
            });

            var errors = new List<Error>
            {
                new Error {Message = "błąd test 1", Date = DateTime.Now},
                new Error {Message = "błąd test 2", Date = DateTime.Now},
                new Error {Message = "błąd test 3", Date = DateTime.Now},

            };

            var report = new Report
            {
                Id = 1,
                Title = "R/1/2020",
                Date = new DateTime(2020, 1, 1, 12, 0, 0),
                Position = new List<ReportPosition>
                {
                    new ReportPosition
                    {
                        Id = 1,
                        ReportId = 1,
                        Title = "Position 1",
                        Description = "Description 1",
                        Value = 43.01M
                    },
                    new ReportPosition
                    {
                        Id = 2,
                        ReportId = 2,
                        Title = "Position 2",
                        Description = "Description 2",
                        Value = 143.01M
                    },
                    new ReportPosition
                    {
                        Id = 3,
                        ReportId = 3,
                        Title = "Position 3",
                        Description = "Description 3",
                        Value = 35.01M
                    }
                }
            };
            Console.WriteLine("wysyłanie e-mail (raport dobowy)");

            email.Send("Raport sprzedaży", htmlEmail.GenerateReport(report), emailReceiver).Wait();

            Console.WriteLine("wysyłanie e-mail ( zakończono)");
            Console.WriteLine("wysyłanie e-mail ( błędy aplikacji)");

            email.Send("Błędy w apce", htmlEmail.GenerateErrors(errors, 10), emailReceiver).Wait();

            Console.WriteLine("wysyłanie e-mail ( zakończono)");

            Console.ReadKey();

        }
    }


}
