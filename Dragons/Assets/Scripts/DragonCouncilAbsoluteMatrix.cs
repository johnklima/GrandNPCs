using System;
using System.Collections.Generic;
using UnityEngine;
using static DragonCouncilAbsoluteMatrix;

public class DragonCouncilAbsoluteMatrix : MonoBehaviour
{
    [System.Serializable]
    public class Dialogue
    {
        public string forceful;
        public string wise;
        public string sarcastic;

        public Dialogue(string f, string w, string s)
        {
            forceful = f;       //ROCK
            wise = w;           //PAPER
            sarcastic = s;      //SCISSORS
        }
    }

    public Dictionary<string, Dictionary<string, Dialogue>> Matrix =
        new Dictionary<string, Dictionary<string, Dialogue>>()
        {

            // ================= HIROSHI =================

            ["Hiroshi"] = new Dictionary<string, Dialogue>()
            {
                ["Aiko"] = new Dialogue(
            "Stand aside, Aiko — I will end this myself!",
            "We are strongest when we trust each other.",
            "Try not to outshine me too much."
        ),
                ["Suki"] = new Dialogue(
            "Leave the battlefield now!",
            "Your courage honors the fallen.",
            "This is no stage performance."
        ),
                ["Sensei"] = new Dialogue(
            "Command me, Sensei!",
            "Your lessons guide my blade.",
            "I hope I pass this test."
        ),
                ["Village Woman"] = new Dialogue(
            "Get to safety immediately!",
            "Your survival is worth any battle.",
            "Please don’t faint now."
        ),
                ["Village Man"] = new Dialogue(
            "Protect your family!",
            "A farmer’s courage feeds nations.",
            "Bad day to leave the fields."
        ),
                ["Lord Kageyama"] = new Dialogue(
            "Your reign ends here!",
            "Power without honor collapses.",
            "Enjoy your last command."
        ),
                ["Lady Kageyama"] = new Dialogue(
            "Stay back, my lady!",
            "Your compassion shames warriors.",
            "Royal visits are ill-timed."
        ),
                ["Male Ninja"] = new Dialogue(
            "Show yourself, coward!",
            "Even shadows answer to steel.",
            "Hiding again?"
        ),
                ["Female Ninja"] = new Dialogue(
            "Face me openly!",
            "Your skill deserves respect.",
            "Enough smoke tricks."
        ),
                ["Dragon"] = new Dialogue(
            "Face me, ancient beast!",
            "Even legends fall to honor.",
            "Try not to scorch everything."
        )
            },

            // ================= AIKO =================

            ["Aiko"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
            "I fight beside you, not behind you!",
            "Together we are unstoppable.",
            "Stop trying to be heroic alone."
        ),
                ["Suki"] = new Dialogue(
            "Stay protected behind us!",
            "Peace is worth more than victory.",
            "No dancing through danger."
        ),
                ["Sensei"] = new Dialogue(
            "Guide us, master!",
            "Your wisdom steadies my heart.",
            "Still evaluating us?"
        ),
                ["Village Woman"] = new Dialogue(
            "Run now!",
            "Your bravery inspires me.",
            "No souvenirs from this battle."
        ),
                ["Village Man"] = new Dialogue(
            "Take cover immediately!",
            "Your duty to family is sacred.",
            "Today is not harvest day."
        ),
                ["Lord Kageyama"] = new Dialogue(
            "Your tyranny stops today!",
            "Mercy is still within reach.",
            "Consider surrender."
        ),
                ["Lady Kageyama"] = new Dialogue(
            "You must leave!",
            "Your kindness shines in darkness.",
            "Royal timing again."
        ),
                ["Male Ninja"] = new Dialogue(
            "Reveal yourself!",
            "A hidden blade still bleeds.",
            "Sneaking won’t save you."
        ),
                ["Female Ninja"] = new Dialogue(
            "Stand and fight!",
            "I respect your resolve.",
            "Enough theatrics."
        ),
                ["Dragon"] = new Dialogue(
            "We will stop you!",
            "Nature must remain balanced.",
            "Bad day for flying."
        )
            },

            // ================= SUKI =================

            ["Suki"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
            "Do not throw your life away!",
            "A calm heart wins wars.",
            "You worry me, you know."
        ),
                ["Aiko"] = new Dialogue(
            "Please be careful!",
            "Strength and grace can coexist.",
            "Don’t scold me later."
        ),
                ["Sensei"] = new Dialogue(
            "Help them survive!",
            "Wisdom is the gentlest power.",
            "No pressure, teacher."
        ),
                ["Village Woman"] = new Dialogue(
            "Stay close to me!",
            "We will endure together.",
            "This is not ideal."
        ),
                ["Village Man"] = new Dialogue(
            "Help protect the children!",
            "Courage blooms in ordinary people.",
            "Worst festival ever."
        ),
                ["Lord Kageyama"] = new Dialogue(
            "Stop this madness!",
            "Fear is not loyalty.",
            "Terrible public relations."
        ),
                ["Lady Kageyama"] = new Dialogue(
            "Your heart is kind!",
            "Compassion heals kingdoms.",
            "Finally someone sensible."
        ),
                ["Male Ninja"] = new Dialogue(
            "Don’t harm them!",
            "Violence leaves deep scars.",
            "Try diplomacy?"
        ),
                ["Female Ninja"] = new Dialogue(
            "Please reconsider!",
            "Freedom need not destroy.",
            "You’re very intense."
        ),
                ["Dragon"] = new Dialogue(
            "Spare us!",
            "Even fury fades.",
            "Please don’t burn the theater."
        )
            },

            // ================= SENSEI =================

            ["Sensei"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
            "Control your anger!",
            "Precision defeats strength.",
            "Stop shouting."
        ),
                ["Aiko"] = new Dialogue(
            "Focus your spirit!",
            "Balance is your greatest weapon.",
            "Less glaring."
        ),
                ["Suki"] = new Dialogue(
            "Remain calm!",
            "Your presence brings harmony.",
            "No panic."
        ),
                ["Village Woman"] = new Dialogue(
            "Take shelter!",
            "Life must be preserved.",
            "Move quickly."
        ),
                ["Village Man"] = new Dialogue(
            "Protect the weak!",
            "Responsibility defines men.",
            "Do not freeze."
        ),
                ["Lord Kageyama"] = new Dialogue(
            "Your ambition blinds you!",
            "A ruler serves first.",
            "History will judge."
        ),
                ["Lady Kageyama"] = new Dialogue(
            "Stay behind me!",
            "Your compassion is strength.",
            "Courage suits you."
        ),
                ["Male Ninja"] = new Dialogue(
            "Enough hiding!",
            "Skill without honor is hollow.",
            "Face daylight."
        ),
                ["Female Ninja"] = new Dialogue(
            "Stand still!",
            "Your speed is admirable.",
            "Patience."
        ),
                ["Dragon"] = new Dialogue(
            "Ancient one, listen!",
            "Destruction breeds emptiness.",
            "You are wiser than this."
        )
            },

            // ================= DRAGON =================

            ["Dragon"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
            "I will incinerate you!",
            "Your courage is rare among mortals.",
            "You are very small."
        ),
                ["Aiko"] = new Dialogue(
            "You dare challenge me?",
            "Your spirit burns bright.",
            "Persistent human."
        ),
                ["Suki"] = new Dialogue(
            "Silence, fragile one!",
            "Fear is natural before power.",
            "You tremble loudly."
        ),
                ["Sensei"] = new Dialogue(
            "Old man, kneel!",
            "Age brings wisdom, not safety.",
            "You lecture a dragon?"
        ),
                ["Village Woman"] = new Dialogue(
            "Do not scream!",
            "Your fear feeds chaos.",
            "You are exhausting."
        ),
                ["Village Man"] = new Dialogue(
            "Run while you can!",
            "Your defiance amuses me.",
            "Slow prey."
        ),
                ["Lord Kageyama"] = new Dialogue(
            "You cannot command me!",
            "Greed destroys kings.",
            "Pathetic ruler."
        ),
                ["Lady Kageyama"] = new Dialogue(
            "You show mercy?",
            "Compassion is unfamiliar.",
            "Strange human."
        ),
                ["Male Ninja"] = new Dialogue(
            "I see you, shadow!",
            "Stealth means nothing to flame.",
            "Nice attempt."
        ),
                ["Female Ninja"] = new Dialogue(
            "Bold insect!",
            "Freedom is a fleeting illusion.",
            "Brave snack."
        )
            },
            //      VILLAGE MAN
            ["Village Man"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
            "Lead us to safety!",
            "Your sword defends us all.",
            "Good thing you showed up."
        ),
                ["Aiko"] = new Dialogue(
            "Protect the evacuation!",
            "Your discipline inspires courage.",
            "You’re very intense."
    ),
                ["Suki"] = new Dialogue(
        "Keep people calm!",
        "Music soothes fear.",
        "Sing later maybe."
    ),
                ["Sensei"] = new Dialogue(
        "Give us direction!",
        "Experience saves lives.",
        "No pressure, elder."
    ),
                ["Village Woman"] = new Dialogue(
        "Stay behind me!",
        "Family comes first.",
        "Worst day ever."
    ),
                ["Lord Kageyama"] = new Dialogue(
        "You abandoned us!",
        "Power must serve the people.",
        "Nice job, lord."
    ),
                ["Lady Kageyama"] = new Dialogue(
        "Help us escape!",
        "Your compassion honors you.",
        "Thank you for caring."
    ),
                ["Male Ninja"] = new Dialogue(
        "Back away slowly!",
        "Stealth won’t hide guilt.",
        "I can see you… barely."
    ),
                ["Female Ninja"] = new Dialogue(
        "Don’t come closer!",
        "There’s still time to leave.",
        "I prefer farming to this."
    ),
                ["Dragon"] = new Dialogue(
        "Go away!",
        "We want only peace.",
        "Find another mountain!"
    )
            },
            //      LORD KAGEYAMA
            ["Lord Kageyama"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
        "You dare challenge your lord?",
        "Order requires strength.",
        "Know your place."
    ),
                ["Aiko"] = new Dialogue(
        "Stand down immediately!",
        "Discipline belongs to rulers.",
        "You serve me."
    ),
                ["Suki"] = new Dialogue(
        "Silence, entertainer!",
        "Beauty exists to serve power.",
        "Return to your stage."
    ),
                ["Sensei"] = new Dialogue(
        "Old man, step aside!",
        "Age does not grant authority.",
        "Retire already."
    ),
                ["Village Woman"] = new Dialogue(
        "Know your station!",
        "Peasants exist under rule.",
        "Stop shouting."
    ),
                ["Village Man"] = new Dialogue(
        "You owe me loyalty!",
        "The strong govern the weak.",
        "Gratitude is rare."
    ),
                ["Lady Kageyama"] = new Dialogue(
        "Do not interfere!",
        "You misunderstand duty.",
        "Return to the palace."
    ),
                ["Male Ninja"] = new Dialogue(
        "Serve me or die!",
        "Assassins are tools of power.",
        "Choose wisely."
    ),
                ["Female Ninja"] = new Dialogue(
        "Kneel before me!",
        "Freedom is illusion.",
        "Defiance is foolish."
    ),
                ["Dragon"] = new Dialogue(
        "Obey me, beast!",
        "Together we rule the land.",
        "I will tame you."
    )
            },
            //      LADY KAGEYAMA
            ["Lady Kageyama"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
        "Protect the innocent!",
        "Honor lives in compassion.",
        "Please hurry."
    ),
                ["Aiko"] = new Dialogue(
        "Stand with us!",
        "Your courage inspires hope.",
        "I trust you."
    ),
                ["Suki"] = new Dialogue(
        "Help calm the people!",
        "Art heals suffering.",
        "Your presence matters."
    ),
                ["Sensei"] = new Dialogue(
        "Guide this chaos!",
        "Wisdom must prevail.",
        "We need you."
    ),
                ["Village Woman"] = new Dialogue(
        "You will be safe!",
        "No one should suffer this.",
        "I promise."
    ),
                ["Village Man"] = new Dialogue(
        "Protect your family!",
        "Love gives strength.",
        "Hold on."
    ),
                ["Lord Kageyama"] = new Dialogue(
        "Stop this madness!",
        "Power without mercy destroys.",
        "You’ve gone too far."
    ),
                ["Male Ninja"] = new Dialogue(
        "Lay down your weapons!",
        "Violence is not destiny.",
        "Choose peace."
    ),
                ["Female Ninja"] = new Dialogue(
        "You deserve freedom!",
        "No one should live in shadows.",
        "Come back to the light."
    ),
                ["Dragon"] = new Dialogue(
        "Spare them!",
        "Mercy honors true strength.",
        "Please."
    )
            },

            //      MALE NINJA

            ["Male Ninja"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
        "You cannot see me.",
        "Direct strength is predictable.",
        "Still looking?"
    ),
                ["Aiko"] = new Dialogue(
        "Too slow.",
        "Discipline has limits.",
        "Heavy armor?"
    ),
                ["Suki"] = new Dialogue(
        "Stay out of this.",
        "Innocence should not bleed.",
        "Wrong place."
    ),
                ["Sensei"] = new Dialogue(
        "Old master, stand aside.",
        "Experience sharpens blades.",
        "You taught many."
    ),
                ["Village Woman"] = new Dialogue(
        "Do not scream.",
        "Fear attracts danger.",
        "Quiet."
    ),
                ["Village Man"] = new Dialogue(
        "Move away.",
        "Survival favors the cautious.",
        "Run."
    ),
                ["Lord Kageyama"] = new Dialogue(
        "I serve no master.",
        "Power shifts like shadows.",
        "Control is illusion."
    ),
                ["Lady Kageyama"] = new Dialogue(
        "Stay back.",
        "Kindness is rare.",
        "Do not interfere."
    ),
                ["Female Ninja"] = new Dialogue(
        "Focus on the mission.",
        "Trust is dangerous.",
        "Keep up."
    ),
                ["Dragon"] = new Dialogue(
        "Even giants fall.",
        "Every creature has a weakness.",
        "Big target."
    )
            },

            //      FEMALE NINJA
            ["Female Ninja"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
        "Catch me if you can.",
        "Honor slows you down.",
        "Predictable."
    ),
                ["Aiko"] = new Dialogue(
        "You fight well.",
        "Strength comes in many forms.",
        "Respect."
    ),
                ["Suki"] = new Dialogue(
        "Stay safe.",
        "Gentleness survives war.",
        "Hide."
    ),
                ["Sensei"] = new Dialogue(
        "Do not block me.",
        "Wisdom sees through shadows.",
        "Impressive."
    ),
                ["Village Woman"] = new Dialogue(
        "Go home.",
        "Civilians should live in peace.",
        "Leave now."
    ),
                ["Village Man"] = new Dialogue(
        "Protect your own.",
        "Family is strength.",
        "Do not follow."
    ),
                ["Lord Kageyama"] = new Dialogue(
        "I bow to no lord.",
        "Chains break eventually.",
        "Control me?"
    ),
                ["Lady Kageyama"] = new Dialogue(
        "You are kind.",
        "Light can reach darkness.",
        "Thank you."
    ),
                ["Male Ninja"] = new Dialogue(
        "Do not slow me down.",
        "We survive together.",
        "Try harder."
    ),
                ["Dragon"] = new Dialogue(
        "I fear nothing.",
        "Freedom is worth risk.",
        "Nice wings."
    )
            },

            // VILLAGE WOMAN

            ["Village Woman"] = new Dictionary<string, Dialogue>()
            {
                ["Hiroshi"] = new Dialogue(
        "Protect us, samurai!",
        "We place our faith in you.",
        "No pressure at all."
    ),
                ["Aiko"] = new Dialogue(
        "Please save the children!",
        "Your bravery gives us hope.",
        "You look like you know what you're doing."
    ),
                ["Suki"] = new Dialogue(
        "Stay close to me!",
        "Kindness keeps fear away.",
        "At least someone is calm."
    ),
                ["Sensei"] = new Dialogue(
        "Tell us what to do!",
        "Wisdom must guide us now.",
        "We’re listening!"
    ),
                ["Village Man"] = new Dialogue(
        "Help me barricade the homes!",
        "We survive together.",
        "Move faster!"
    ),
                ["Lord Kageyama"] = new Dialogue(
        "This is your fault!",
        "A ruler must protect the people.",
        "Great leadership."
    ),
                ["Lady Kageyama"] = new Dialogue(
        "Please stop him!",
        "You are our last hope.",
        "Nobility finally useful."
    ),
                ["Male Ninja"] = new Dialogue(
        "Stay away from us!",
        "Violence breeds only sorrow.",
        "Creepy shadow."
    ),
                ["Female Ninja"] = new Dialogue(
        "Don’t hurt anyone!",
        "You still have a choice.",
        "You look dangerous."
    ),
                ["Dragon"] = new Dialogue(
        "Leave our village!",
        "Even monsters can choose mercy.",
        "Pick another place to destroy!"
    )
            },


        };


}