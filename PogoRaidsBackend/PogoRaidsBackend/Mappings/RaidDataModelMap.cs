using FluentNHibernate.Mapping;
using PogoRaidsBackend.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PogoRaidsBackend.Mappings
{
    class RaidDataModelMap: ClassMap<RaidDataModel>
    {
        public RaidDataModelMap()
        {
            Id(x => x.Id);
            Map(x => x.MinimalLevel);
            Map(x => x.StartsIn);
            References(x => x.Pokemon).Not.LazyLoad();
            References(x => x.Creator).Not.LazyLoad();
            HasManyToMany(x => x.Contendors).Not.LazyLoad().Cascade.All().Table("UserRaid");
        }
    }
}
