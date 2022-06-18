

namespace cse210_02
{
     /// <summary>
    /// A card with a random value of 1-13
    /// </summary> 
    public class Card
    {
        public int CardValue;
       
        /// <summary>
        /// Creates new instance of Cards
        /// </summary>
        public Card() {
            Random random = new Random();
            CardValue = random.Next(1,14);

        }


    }
}
