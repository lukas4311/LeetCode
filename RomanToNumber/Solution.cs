using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security;

namespace RomanToNumber
{
    public class Solution
    {
        private readonly Dictionary<char, RomanCharacter> CharacterMap = new Dictionary<char, RomanCharacter>()
        {
            {'I', new RomanCharacter{ Value = 1, SpecialCharacterValue = new []{ ('X', 9), ('V', 4) }  } }
            ,{'V' , new RomanCharacter{ Value = 5, SpecialCharacterValue = null  }}
            ,{'X' , new RomanCharacter{ Value = 10, SpecialCharacterValue = new []{ ('L', 40), ('C', 90) }  }}
            ,{'L', new RomanCharacter{ Value = 50, SpecialCharacterValue = null  }}
            ,{'C', new RomanCharacter{ Value = 100, SpecialCharacterValue = new []{ ('D', 400), ('M', 900) }  }}
            ,{'D', new RomanCharacter{ Value = 500, SpecialCharacterValue = null  }}
            ,{'M', new RomanCharacter{ Value = 1000, SpecialCharacterValue = null }}
        };

        struct RomanCharacter
        {
            public int Value { get; set; }

            public (char character, int newValue)[] SpecialCharacterValue { get; set; }
        }

        public int RomanToInt(string s)
        {
            if (s.Length == 0)
                return 0;

            int sum = 0;
            RomanCharacter character;
            int toSum = 0;

            for (int i = 0; i < s.Length; i++)
            {
                character = this.CharacterMap[s[i]];

                if (i + 1 < s.Length)
                {
                    toSum = character.SpecialCharacterValue?.SingleOrDefault(a => a.character == s[i + 1]).newValue ?? 0;

                    if(toSum != 0)
                    {
                        sum += toSum;
                        i++;
                        continue;
                    }
                }

                sum += character.Value;
            }

            return sum;
        }
    }
}
