namespace Doggo.Infrastructure
{
    public class DoggoRepository : IDoggoRepository
    {
        private static readonly string[] Datas = new[]
        {
            "Rex",
            "Krypto",
            "Flash",
            "Rudy",
            "Scooby-Doo",
            "Marshall",
            "Rocky",
            "Chase",
            "Oscar",
            "Tuck",
            "Atlas",
            "Skye",
            "Milo",
            "Finn"
        }.Distinct().ToArray();

        public IEnumerable<Domain.Doggo> GetDoggoName(dynamic query)
        {
            var limit = (int)query.Limit;
            if (limit >= Datas.Length || limit < 1)
                limit = 1;

            return Enumerable.Range(0, limit).Select(index => new Domain.Doggo
            {
                Name = Datas[index]
            }); ;
        }
    }
}
