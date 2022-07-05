using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class FootballersService
    {
        private FootballerRepository footballersRepository;

        public FootballersService(FootballerRepository footballersRepository)
        {
            this.footballersRepository = footballersRepository;
        }

        public async Task Add(Footballer footballer)
        {
            await footballersRepository.Add(footballer);
        }

        public async Task<Footballer> GetFootballer(int id)
        {
            return await footballersRepository.Get(id);
        }

        public async Task<List<Footballer>> GetFootballers()
        {
            return await footballersRepository.GetAll();
        }

        public async Task Edit(Footballer footballer)
        {
            if (!(await footballersRepository.Exists(footballer.Id)))
                return;
            await footballersRepository.Edit(footballer);
        }

        public async Task Delete(int id)
        {
            await footballersRepository.Delete(id);
        }
    }
}
