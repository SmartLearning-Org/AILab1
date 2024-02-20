namespace AILab1.services
{
    public class IdeService
    {
        /// <summary>
        /// Henter tre forslag til aktiviteter baseret på en persons alder
        /// </summary>
        /// <param name="alder">Personens alder</param>
        /// <returns>et array med ideer. Et tomt array, hvis noget fejler</returns>
        public async Task<string[]> GetIdeer(int alder)
        {
            // TODO: Slet nedenstående kode og implementer løsningen på Del 1 her
            string[] result = Array.Empty<string>();
            return result;
        }

        /// <summary>
        /// Henter tre forslag til aktiviteter baseret på flere personers aldre
        /// </summary>
        /// <param name="alder">Personernes aldre</param>
        /// <returns>et array med ideer. Et tomt array, hvis noget fejler</returns>
        public async Task<string[]> GetIdeer(int[] aldre)
        {
            // TODO: Slet nedenstående kode og implementer løsningen på Del 2 her
            string[] result = Array.Empty<string>();
            return result;
        }
    }
}
