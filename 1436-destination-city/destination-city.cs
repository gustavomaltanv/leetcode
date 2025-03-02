public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        List<string> origin = new List<string>();
        List<string> destination = new List<string>();

        foreach(var path in paths) {
            origin.Add(path[0]);
            destination.Add(path[1]);
        }
        string answer = "";
        foreach(var dest in destination) {
            if(!origin.Contains(dest)) {
                answer = dest;
                break;
            }
        }

        return answer;
    }
}