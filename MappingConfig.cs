﻿using Fundraise.Core.Entities;
using Fundraise.MvcExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fundraise.MvcExample
{
    public static class MappingConfig
    {
        public static void RegisterMaps()
        {
            AutoMapper.Mapper.Initialize(config =>
            {
                config.CreateMap<Campaign, CampaignViewModel>();
                config.CreateMap<Campaign, CampaignFormViewModel>();
                config.CreateMap<Fundraiser, FundraiserViewModel>();
                config.CreateMap<Fundraiser, FundraiserFormViewModel>();
                config.CreateMap<Donation, DonationViewModel>();
            });
        }
    }
}