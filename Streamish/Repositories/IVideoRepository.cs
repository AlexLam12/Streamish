using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Streamish.Models;

namespace Streamish.Repositories
{
    public interface IVideoRepository
    {
        void Add(Video video);
        void Delete(int id);
        Video GetById(int id);
        List<Video> GetAll();
        void Update(Video video);
        List<Video> GetAllWithComments();
        List<Video> Search(string q, bool sortDesc);
    }
}
