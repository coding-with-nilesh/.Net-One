using One.Core.Guid;
using System;
using GUID = System.Guid;

namespace One.Infrastructure.Guid
{
    public class GuidService : IGuidService
    {
        public string GetGuid() => GUID.NewGuid().ToString();

        public string GetShortGuid()
        {
            var ticks = new DateTime(2021, 1, 1).Ticks; // First data which will be used as reference. Keep it latest to reduce length of id.
            var ans = DateTime.Now.Ticks - ticks;
            return ans.ToString("x");
        }
    }
}
