namespace Doggo.Infrastructure
{
    public class DoggoBreedRepository : IDoggoBreedRepository
    {
        private static readonly string[] Datas = new[]
        {
            "Akita",
            "English Setter",
            "Shar Pei",
            "Norfolk Spaniel",
            "Paisley Terrier",
            "Tonya Finosu",
            "Can de Chira",
            "Pumi",
            "Beagle",
            "Japanese Chin",
            "Labrador Retriever",
            "Plott Hound",
            "Zerdava",
            "Toy Bulldog",
            "Norman Hound",
            "Great Dane",
            "English Cocker Spaniel",
            "Old Spanish Pointer",
            "Continental bulldog",
            "Limer"
        }.Distinct().ToArray();

        public IEnumerable<Domain.DoggoBreed> GetDoggoBreed(dynamic query)
        {
            var limit = (int)query.Limit;
            if (limit >= Datas.Length || limit < 1)
                limit = 1;

            return Enumerable.Range(0, limit).Select(index => new Domain.DoggoBreed
            {
                Breed = Datas[index]
            }); ;
        }
    }
}
