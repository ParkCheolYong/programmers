class Solution {
    public String solution(String m, String[] musicinfos) {
        String answer = "(None)";

        m = m.replace("C#", "1").replace("D#", "2").replace("F#", "3").replace("G#", "4").replace("A#", "5");

        int playTime = 0;

        for (int i = 0; i < musicinfos.length; i++)
        {
            String[] music = musicinfos[i].split(",");

            String[] startTime = music[0].split(":");
            String[] endTime = music[1].split(":");

            int hour = Integer.parseInt(endTime[0]) - Integer.parseInt(startTime[0]);
            int min = Integer.parseInt(endTime[1]) - Integer.parseInt(startTime[1]) + (60 * hour);

            music[3] = music[3].replace("C#", "1").replace("D#", "2").replace("F#", "3").replace("G#", "4").replace("A#", "5");

            String sheetMusic = "";

            for (int j = 0; j < min; j++)
            {
                sheetMusic += music[3].charAt(j % music[3].length());
            }

            if (sheetMusic.contains(m))
            {
                if (playTime < min)
                {
                    playTime = min;
                    answer = music[2];

                }
            }
        }

        return answer;
    }
}