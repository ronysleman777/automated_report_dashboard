﻿using System.Text.Json;

namespace automated_report_dashboard.Data
{
    public static class Helper
    {
        public static Guid UserId { get; set; } /*= new Guid("10f3562f-1a07-4dab-a16b-8b64855df56d");*/
        public static Guid CertificateId { get; set; }
        public static Guid DivisionId { get; set; }
        public static Guid HallId { get; set; }
        public static Guid TeacherId { get; set; }
        public static Guid ClassId { get; set; }
        public static Guid StudentId { get; set; }
        public static T ToObj<T>(this object data)
        {
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            var Result = JsonSerializer.Deserialize<T>(data.ToString(), options);
            return Result;
        }
        public static bool IsManager()
        {
            var ManagerId = new Guid("8bc9d900-e353-4cc1-ae90-37d31a0688ee");
            if (UserId == ManagerId)
                return true;
            return false;
        }

    }
}
