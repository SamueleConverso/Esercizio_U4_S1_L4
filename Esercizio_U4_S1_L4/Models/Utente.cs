namespace Esercizio_U4_S1_L4.Models {
    public static class Utente {

        private static string username;
        private static string password;
        private static DateTime dateLogin;
        private static List<DateTime> dates;
        private static bool isLogged;

        public static string Username {
            get; set;
        } = "";

        public static string Password {
            get; set;
        } = "";

        public static DateTime DateLogin {
            get; set;
        }

        public static List<DateTime> Dates {
            get; set;
        } = new List<DateTime>();

        public static bool IsLogged {
            get; set;
        } = false;

        public static void Login(string username, string password, string confirmPassword) {
            if (username != null && username != "" && username != " " && password != null && password != "" && password != " " && confirmPassword != null && confirmPassword != "" && confirmPassword != " " && password == confirmPassword) {
                IsLogged = true;
                DateLogin = DateTime.Now;
                Dates.Add(DateLogin);
            }
        }
    }
}
