namespace DemoRepPattern.Models
{
    public class Joueur
    {
        public string Id { get; set; }
        public string Nom { get; set; }

        public Joueur() { }

        public Joueur(string id, string nom)
        {
            Id = id;
            Nom = nom;
        }
    }
}
