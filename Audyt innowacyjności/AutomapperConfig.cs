using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Audyt_innowacyjności.ViewModel;
using AutoMapper;

namespace Audyt_innowacyjności
{
    public static class AutoMapperConfig
    {
        public static IMapper GetMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Survey, SurveyViewModel>();
                cfg.CreateMap<SurveyViewModel, Survey>();
                //lots more maps...?
            });

            IMapper mapper = config.CreateMapper();
            return mapper;
        }
    }
}
