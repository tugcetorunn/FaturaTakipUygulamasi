using AutoMapper;
using FaturaTakipUygulamasi.Models;
using FaturaTakipUygulamasi.ViewModels.Auth;
using FaturaTakipUygulamasi.ViewModels.Faturalar;

namespace FaturaTakipUygulamasi.Mappers
{
    /// <summary>
    /// mapper sınıfı ile viewmodel ve entity sınıfları arasında iki yönlü dönüşüm yapabiliyoruz.
    /// </summary>
    public class ProjectMapper : Profile
    {
        public ProjectMapper()
        {
            CreateMap<Uye, RegisterVM>().ReverseMap();
            CreateMap<Fatura, FaturaListeleVM>().ForMember(dest => dest.Musteri, opt => opt.MapFrom(src => src.Musteri.AdSoyad)).ReverseMap();
        }
    }
}
