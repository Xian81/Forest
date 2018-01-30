using System.Collections.Generic;
using Forest.Data;
using Forest.Data.IDAO;
using Forest.Data.DAO;


namespace Forest.Services.Service
{
    public class MusicService:
        Forest.Services.IService.IMusicService

    {
        private IMusicDAO _musicDAO;
    
        public MusicService()
                                    {
            _musicDAO = new MusicDAO();    }


    public IList<Music_Category>GetMusicCategories()

    {


        return _musicDAO.GetMusicCategories();
        


    }
        public IList<Music_Recording> GetMusicRecordings(string genre)
        {

            return _musicDAO.GetMusicRecordings(genre);



        }

        public Music_Recording GetMusicRecording(int Id)
        {
            return _musicDAO.GetMusicRecording(Id);
        }




        public void EditMusicRecording(Music_Recording recording)
        
        {

            _musicDAO.EditMusicRecording(recording);

        }

        public void AddMusicRecording(Music_Recording recording)
        {
            _musicDAO.AddMusicRecording(recording);
        }



        public void DeleteMusicRecording (Music_Recording recording)
        {

            _musicDAO.DeleteMusicRecording(recording);



        }




        //to implement
        //Method name:GetMusicRecordings
        //Return type:ILIst<Music Recording>
        //Parameter type:string
        //Parameter name:genre
        //Call the appropriate method of your DAO 
        //and return the result  


        // This order:

        // class
        // attributes
        //constructor
        //method


    }
}
