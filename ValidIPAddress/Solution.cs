namespace ValidIPAddress
{
    using System.Collections.Generic;

    public class Solution
    {
        public string ValidIPAddress(string IP) {
            string[] divs = IP.Split('.');
            if(divs.Length > 1){
                // IPV4 validation
                if(divs.Length != 4){
                    return "Neither";
                }
                foreach(var str in divs){
                    if(string.IsNullOrEmpty(str)){
                        return "Neither";
                    }
                    if(str[0] == '0'){
                        return "Neither";
                    }
                    if(int.TryParse(str,out int val)){
                        if(val > 255 || val < 0){
                            return "Neither";
                        }
                    }else
                    {
                        return "Neither";
                    }
                    
                }
                return "IPv4";
            }
            else
            {
                //IPV6 validation
                divs = IP.Split(':');
                if(divs.Length != 8){
                    return "Neither";
                }
                if(divs[0].Length > 4){
                    if(divs[0][0] == '0'){
                        return "Neither";
                    }
                }
                var hexdigitsSet = new HashSet<char>("0123456789abcdefABCDEF".ToCharArray());
                foreach(var str in divs){
                    if(string.IsNullOrEmpty(str)){
                        return "Neither";
                    }
                    if(str.Length > 4){
                        return "Neither";
                    }
                    foreach(var ch in str.ToCharArray()){
                        if(!hexdigitsSet.Contains(ch)){
                            return "Neither";
                        }
                    }
                }
            
                return "IPv6";
            }
        }
    }
}