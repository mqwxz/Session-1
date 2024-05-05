using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationSecurity.Classes
{
    internal class User
    {
        public static int id {  get; set; }
        public static string lastName { get; set; }
        public static string firstName { get; set; }
        public static string middleName { get; set; }
        public static string email { get; set; }
        public static string password { get; set; }
        public static string gender { get; set; }
        public static DateTime birthday { get; set; }
        public static int country { get; set; }
        public static string phone { get; set; }
        public static int direction { get; set; }
        public static int userEvent { get; set; }
        public static string photo { get; set; }
        public static int role { get; set; }

        public static string hello => lastName + ' ' + firstName + ' ' + middleName;

        public static string Welcome(string message)
        {
            /*
             * Приветствие пользователя по ФИО с указанием времени работы: 
             * 9:00 - 11.00 - Утро
             * 11:00 - 18:00 - День
             * 18:00 - 24:00 - Вечер
             * Отсутствует ночь.
            */

            int currentHour = DateTime.Now.Hour;
            string time = string.Empty;

            if (9 <= currentHour && currentHour < 11)
            {
                time = "Доброе утро!";
            }

            if (11 <= currentHour && currentHour < 18)
            {
                time = "Добрый день!";
            }

            if (18 <= currentHour && currentHour < 24)
            {
                time = "Добрый вечер!";
            }

            message = $"{time} \n{hello}";
            return message;
        }

        public static void InitializeUser(SqlDataReader sqlDataReader)
        {
            id = sqlDataReader.GetInt32(0);
            firstName = sqlDataReader.GetString(1);
            lastName = sqlDataReader.GetString(2);
            middleName = sqlDataReader.GetString(3);
            email = sqlDataReader.GetString(4);
            password = sqlDataReader.GetString(5);
            gender = sqlDataReader.GetString(6);
            birthday = sqlDataReader.GetDateTime(7);
            country = sqlDataReader.GetInt32(8);
            phone = sqlDataReader.GetString(9);
            direction = sqlDataReader.GetInt32(10);
            userEvent = sqlDataReader.GetInt32(11);
            photo = sqlDataReader.GetString(12);
            role = sqlDataReader.GetInt32(13);
        }
    }
}
