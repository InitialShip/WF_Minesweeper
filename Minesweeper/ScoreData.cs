using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Minesweeper
{
    [DataContract]
    public class ScoreData
    {
        [DataMember]
        public ScoreLevel Easy { get; set; }
        [DataMember]
        public ScoreLevel Medium { get; set; }
        [DataMember]
        public ScoreLevel Hard { get; set; }
        public ScoreData()
        {
            Easy = new ScoreLevel();
            Medium = new ScoreLevel();
            Hard = new ScoreLevel();
        }
        public void AddRecordToEasy(Record record)
        {
            Easy.AddRecord(record);
        }
        public void AddRecordToMedium(Record record)
        {
            Medium.AddRecord(record);
        }
        public void AddRecordToHard(Record record)
        {
            Hard.AddRecord(record);
        }
        public int GetRank(int levelId,Record record)
        {
            switch (levelId) 
            {
                case 1:
                    return Easy.GetRank(record);
                case 2:
                    return Medium.GetRank(record);
                default:
                    return Hard.GetRank(record);
            }
        }
        
    }
    public class ScoreLevel
    {
        public string LevelName { get; set; }
        public List<Record> Records { get; set; }
        public ScoreLevel() {
            Records = new List<Record>();
        }
        public ScoreLevel(string name,List<Record> records)
        {
            LevelName = name;
            Records = records;
        }
        public List<Record> GetRecords()
        {
            return Records;
        }
        public void AddRecord(Record record)
        {
            Records.Add(record);
            MySort();

            if (Records.Count > 10)
                Records = Records.Take(10).ToList();
        }
        private void MySort()
        {
            Records.Sort((r1, r2) =>
            {
                return r1.CompareTo(r2);
            });
        }
        public int GetRank(Record record)
        {
            if (Records.Count == 0)
                return 1;
            return Records.IndexOf(record) + 1;
        }
    }
    /*
     * Name : tên người chơi
     * MainRemain : số mìn chưa nổ còn lại
     * Time : thời gian hoàn thành game
     */
    public class Record : IComparable<Record>
    {
        public string Name { get; set; }
        public int MineRemain { get; set; }
        public int Time { get; set; }
        public Record() { }
        public Record (string name, int mine,int time)
        {
            Name = name;
            MineRemain = mine;
            Time = time;
        }
        public int CompareTo(Record other)
        {
            int comp = MineRemain.CompareTo(other.MineRemain);
            if (comp == 0)
            {
                comp = Time.CompareTo(other.Time);
                return comp;
            }
            return -1*comp;
        }
    }
}
