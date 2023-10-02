namespace skyrim_project
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDto> ();
            CreateMap<AddCharacterDto, Character> ();
        }
    }
}
