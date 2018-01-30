using Forest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Services.IService
{
    public interface IMusicService
    {

        IList<Forest.Data.Music_Category> GetMusicCategories();
        IList<Forest.Data.Music_Recording> GetMusicRecordings(string genre);

        Forest.Data.Music_Recording GetMusicRecording(int Id);

        void EditMusicRecording(Forest.Data.Music_Recording recording);


        void AddMusicRecording(Forest.Data.Music_Recording recording);


        void DeleteMusicRecording(Forest.Data.Music_Recording recording);









    }
}
