
namespace CasinoProject.Repo
{
    public class PlayerRepo
    {
        private readonly string Name;
        private readonly string Email;
        private readonly int Amount;

        public PlayerRepo(string name, string email)
        {
            if (name == null) 
            {
                throw new ArgumentNullException("name");
            }
            if (email == null || !email.Contains('@'))
            {
                throw new ArgumentNullException("email");
            }
            Name = name;
            Email = email;
            Amount = 0;
        }

    }
}
