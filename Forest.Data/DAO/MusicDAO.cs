using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Forest.Data.DAO;
using Forest.Data.IDAO;

namespace Forest.Data.DAO
{
    public class MusicDAO : IMusicDAO
    {
        private ForestEntities _context;
        public MusicDAO() { _context = new ForestEntities(); }



        public Music_Recording GetMusicRecording(int Id)

        {
            IQueryable<Music_Recording> _recording;
            _recording = from recording
                         in _context.Music_Recording
                         where recording.Id == Id
                         select recording;
            return _recording.ToList<Music_Recording>().First();


        }


        // to remove the list wrapper use the .First(); 

        // match the variable to the where. Make sure these match. 


        
      public IList<Music_Recording> GetMusicRecordings(string genre)
        {

            IQueryable<Music_Recording>_recordings;
            _recordings = from recording
                          in _context.Music_Recording
                          where recording.Genre == genre
                          select recording;
            return _recordings.ToList<Music_Recording>();

            //Select * from Music_Recording as recording
            //    where recording.genre==myGenre
          
        //This is a method to call information from the Music_Recording table.

        }


	public IList<Music_Category> GetMusicCategories()
		{

            IQueryable<Music_Category> _categories;
            _categories = from category
                          in _context.Music_Category
                          select category;
            return _categories.ToList < Music_Category>();




        }



    public void EditMusicRecording(Music_Recording recording)

        {

            Music_Recording record = GetMusicRecording(recording.Id);
            record.Artist = recording.Artist;
            record.Genre = recording.Genre;
            record.Image_Name = recording.Image_Name;
            record.Num_Tracks = recording.Num_Tracks;
            record.Price = recording.Price;
            record.Released = recording.Released;
            record.Stock_Count = recording.Stock_Count;
            record.Title = recording.Title;
            //record.Url = recording.Url;
            _context.SaveChanges();



            
        }

    public void AddMusicRecording(Music_Recording recording)

        {

            _context.Music_Recording.Add(recording);
            _context.SaveChanges();



        }



    public void DeleteMusicRecording(Music_Recording recording)
        {


            _context.Music_Recording.Remove (recording);
            _context.SaveChanges();



        }

    

        //ForestEntities does not contain a defintion(what does this mean ? ). 

    }
}
