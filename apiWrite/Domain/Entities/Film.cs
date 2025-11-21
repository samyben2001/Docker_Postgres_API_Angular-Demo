namespace MovieApiWrite.Domain.Entities
{
    public class Film
    {
        public int Id { get; set; }
        public string TitreFR { get; set; }
        public string TitreCA { get; set; }
        public int Annee { get; set; }

        public Film(int id, string titreFR, string titreCA, int annee)
        {
            Id = id;
            TitreFR = titreFR;
            TitreCA = titreCA;
            Annee = annee;
        }
    }
}
