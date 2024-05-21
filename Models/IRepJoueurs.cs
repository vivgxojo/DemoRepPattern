namespace DemoRepPattern.Models
{
    public interface IRepJoueurs
    {
        List<Joueur> LesJoueurs();

        Joueur GetJoueur(string joueurId);

        void AjouterJoueur(Joueur joueur);

        void ModifierJoueur(string joueurId, Joueur joueur);

        void SupprimerJoueur(string joueurId);
    }
}
