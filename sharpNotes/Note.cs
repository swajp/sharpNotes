using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sharpNotes
{
    public class Note
    {
        public int NoteId { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public int OwnerId { get; set; }

        public Note(int noteId, string title, string text, int ownerId)
        {
            NoteId = noteId;
            Title = title;
            Text = text;
            OwnerId = ownerId;
        }
    }
}
