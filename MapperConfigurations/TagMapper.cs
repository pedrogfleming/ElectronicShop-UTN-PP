using ElectronicShop.Models.Products.Tags;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicShop.MapperConfigurations
{
    public static class TagMapper
    {
        /// <summary>
        /// Concatenate all the tags recieved to an large string
        /// separeted with comma
        /// </summary>
        /// <param name="tags">The list of tags to concatenate</param>
        /// <returns>A string with all the name tags</returns>
        public static string ConcatenateTags(List<Tag> tags)
        {
            StringBuilder sb = new();
            sb.AppendJoin(", ",tags.Select(t => t.Name));
            return sb.ToString();
        }
    }
}
