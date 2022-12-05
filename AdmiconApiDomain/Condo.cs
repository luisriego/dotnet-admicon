using Admicon.Domain.Common;

namespace Admicon.Domain
{
    public class Condo : BaseDomainModel
    {
        public string Cnpj { get; set; } = string.Empty;
        public string FantasyName { get; set; } = string.Empty;
        public string SocialName { get; set; } = string.Empty;
    }
}
