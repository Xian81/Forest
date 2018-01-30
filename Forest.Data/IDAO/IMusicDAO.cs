using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forest.Data.IDAO
{
    public interface IMusicDAO {



        //To implement;
        //Method name: GetMusicRecordings>
        //Return type: IList<Music_Recordings>
        //Parameter type:string
        //Parameter name:genre


        IList<Forest.Data.Music_Category> GetMusicCategories();

        IList<Forest.Data.Music_Recording> GetMusicRecordings(string genre);

        Forest.Data.Music_Recording GetMusicRecording(int Id);


        void EditMusicRecording(Forest.Data.Music_Recording recording);


        void AddMusicRecording(Music_Recording recording);


        void DeleteMusicRecording(Music_Recording recording);
        
        //Do not use <> brackets these are only for a list.

        //This is the interface that calls the methods in MusicDAO.


        //Need to have an input if this leads to other categories. 


    }

}

    
 


           

    


