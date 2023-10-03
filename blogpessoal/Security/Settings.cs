namespace blogpessoal.Security
{
    public class Settings
    {
        private static string secret = "bdec7a3dbc813f268c319368a6056ed4b87c6c0d75ac45c5ac058e019ad80f8c";
        public static string Secret { get => secret; set => secret = value; }
    }
}
