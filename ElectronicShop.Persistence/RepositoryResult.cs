using System.Collections.Generic;

namespace ElectronicShop.Persistence
{
    public class RepositoryResult
    {
        public RepositoryResult(bool success, List<string> list)
        {
            Success = success;
            Errors = list;
        }

        public bool Success{ get; set; }
        public List<string> Errors { get; set; }
    }
}
