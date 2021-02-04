using PogoRaids.API.DOMModels;
using PogoRaids.API.Models;
using PogoRaidsBackend.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PogoRaids.API.Services
{
    public interface IPokemonService
    {
        PokemonModel Save(PokemonDOM pokemonModel);
        IList<PokemonModel> GetAll();
        PokemonModel Get(long id);
        void Delete(long id);
    }
}
