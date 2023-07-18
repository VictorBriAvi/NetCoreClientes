namespace NetCoreYouTube.Models
{
    public class Usuario
    {
        public string IdUser  { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string rol { get; set; }
        public static List<Usuario>  DB ()
        {
            var list = new List<Usuario>()
            {
                new Usuario
                {
                    IdUser = "1",
                    User = "Victor",
                    Password = "123.",
                    rol = "empleado",

                },
                new Usuario
                {
                    IdUser = "2",
                    User = "Mailen",
                    Password = "123.",
                    rol = "asesor",

                },
                new Usuario
                {
                    IdUser = "3",
                    User = "Nala",
                    Password = "123.",
                    rol = "administrador",

                },
            };
            return list;
        }
    }
}
