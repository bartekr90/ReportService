﻿using ReportService.Core.Domains;
using System;
using System.Collections.Generic;

namespace ReportService.Core.Repositories
{
    public class ReportRepository
    {
        public Report GetLastNotSentReport()
        {
            // pobieranie z bazy danych ostatniego raportu

            return new Report
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
        }

        public void ReportSent(Report report)
        {
            report.IsSend = true;
            //zapis do bazy
        }
    }
}
