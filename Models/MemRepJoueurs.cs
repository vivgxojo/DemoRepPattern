namespace DemoRepPattern.Models
{
    public class MemRepJoueurs : IRepJoueurs
    {
        List<Joueur> lstJoueurs = new List<Joueur> {
            new Joueur("1", "Bob"),
            new Joueur("2", "Jessy")
        };

        public List<Joueur> LesJoueurs()
        {
            return lstJoueurs;
        }

        public Joueur GetJoueur(string joueurId)
        {
            Joueur joueur = lstJoueurs.FirstOrDefault(j => j.Id == joueurId);
            return joueur;
        }

        public void AjouterJoueur(Joueur joueur)
        {
            lstJoueurs.Add(joueur);
        }

        public void ModifierJoueur(string joueurId, Joueur joueur)
        {
            int i = lstJoueurs.IndexOf(GetJoueur(joueurId));
            lstJoueurs[i] = joueur;
        }

        public void SupprimerJoueur(string joueurId)
        {
            lstJoueurs.Remove(GetJoueur(joueurId));
        }
    }
}
