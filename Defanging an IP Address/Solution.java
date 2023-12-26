public class Solution 
{
    public String defangIPaddr(String address) 
    {
        String [] addresArray  = address.split("'\\.'");
        String finalAddress = "";
        for(int i = 0; i < addresArray.length; i++ )
        {
            if(i == (addresArray.length-1))
            {
                finalAddress = finalAddress + addresArray[i];
            }
            else
            {
                finalAddress = finalAddress + addresArray[i] + "[.]";
            }

        } 
        return finalAddress;
    }
}

