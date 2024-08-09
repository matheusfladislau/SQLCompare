namespace SQLCompare {
    public class Credencial {
        public string DataSource { get; set; }
        public string InitialCatalog { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }


        public Credencial(string DataSource, string InitialCatalog, string UserID, string Password) {
            this.DataSource = DataSource;
            this.InitialCatalog = InitialCatalog;
            this.UserID = UserID;
            this.Password = Password;
        }
    }
}
