using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace music.Models.Music
{
    public class MusicRequest
    {
        public string Title { get; set; }
    }
}