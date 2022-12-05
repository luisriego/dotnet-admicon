using Admicon.Domain.Common;

namespace Admicon.Domain
{
    public class Entry : BaseDomainModel
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int ValueCents { get; set; } = 0;
        public bool IsCredit { get; set; } = false;
        public bool IsDebit { get; set; } = false;
        public bool IsTransfer { get; set; } = false;
        public DateTime? Due { get; set; }
        public int State { get; set; } = 0;

        public virtual Condo? Condo { get; set; }
    }
}