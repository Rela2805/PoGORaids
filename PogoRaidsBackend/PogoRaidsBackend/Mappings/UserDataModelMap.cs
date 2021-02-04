using FluentNHibernate.Mapping;
using PogoRaidsBackend.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PogoRaidsBackend.Mappings
{
    class UserDataModelMap: ClassMap<UserDataModel>
    {
        public UserDataModelMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.Password);
            Map(x => x.Email);
            Map(x => x.RaidsCompleted);
            Map(x => x.Username);
            Map(x => x.Level);
            Map(x => x.GameNickname);
            Map(x => x.GameCode);
            References(x => x.Team).Not.LazyLoad();
            HasMany(x => x.CreatedRaids).Not.LazyLoad().Inverse().Cascade.All();
            HasManyToMany(x => x.ParticipatedRaids).Not.LazyLoad().Inverse().Cascade.All().Table("UserRaid");
        }
    }
}
