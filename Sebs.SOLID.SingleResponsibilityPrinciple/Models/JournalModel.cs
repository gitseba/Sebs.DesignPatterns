namespace Sebs.SingleResponsibilityPrinciple
{
    public class JournalModel
    {
        public string Header { get; set; }

        public string BodyText { get; set; }
        
        public void AddEntry(string text)
        {
            BodyText = text;
        }

        public void RemoveEntry(int rowIndex)
        {
            BodyText.Remove(rowIndex);
        }


        //******** One of the motives to break SRP, would be to start implementation for saving journal file
        // Because, this class would have the concern of adding entries, and also to save/load file, which means it would have multiple responsabilities.
        public void SaveFile(JournalModel journal)
        {
            //save journal logic...
        }

        public void LoadFile(string journalpath)
        {
            //load journal logic...
        }
        //******** This methods would be better to be extracted into another class, E.g Persistance,
        // Which would have the responsability of saving text.
    }
}
