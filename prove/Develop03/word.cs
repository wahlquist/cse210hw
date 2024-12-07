class Hide 
{


     List<int> HideThese = new List<int> { 0,1, 2, 3, 4, 5,6,7,8,9,10,11,12, 13 };

 
    public int GetHide ()
    {         
Random random = new Random();

        // Generate a random index
        int randomIndex = random.Next(HideThese.Count);

        // Get the random item
        int randomItem = HideThese [randomIndex];
        HideThese.Remove(randomItem);
       
       
       return randomItem;
    }




}
