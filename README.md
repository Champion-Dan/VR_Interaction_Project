﻿# VR_Interaction_Project

# VR Interaction Proposal 
**Hernandez, Daniel**

## What interaction are you exploring?
Turning a knob to adjust volume or lighting levels (Adjusting things).

## Different ways are you going to implement it?
1. **Physical Knob Rotation**
2. **Gesture-Based Knob Control**
3. **Voice Command (Maybe)**
4. **Touch and Rotate**
5. **Snap Rotation**


Overview
This project explores VR interaction mechanisms, focusing on implementing and refining proximity triggers and sound-based UI elements. The primary interactions include proximity-based triggers for activating UI components and a sound bar adjustment using VR controls.

Core Interactions
Proximity Triggers
This feature includes a proximity-based activation system for game elements, with one of the triggers using the player's hand and hand colliders to detect interactions. For this specific trigger, the button only activates after the user holds their hand over it for a short period, adding a deliberate, timed interaction.

Sound Bar Adjustment
A slider UI for adjusting sound levels, ideal for rhythm games or mini-games, introduces an interactive sound adjustment element within the VR environment.

Versions Implemented
Version 1
Basic proximity trigger detection, where proximity actions are initiated by the player's hand or controller within range of the sensor.

Version 2
Added adjustments based on initial feedback, including trigger height and sensitivity. Additionally, the hand-based trigger was refined to require the user to hold their hand within range for a short duration before activation, creating a more intentional interaction. The sound bar was also improved for smoother, more responsive adjustments.

User Testing: Observations and Reflections
Testing revealed that interactions with proximity triggers generally met user expectations, though some tweaks were necessary. For example, users suggested raising certain triggers for comfort, and others highlighted the value of consistent trigger sensitivity.

Key Takeaways
Trigger Height and Sensitivity: Adjustments to the trigger height improved access, reducing issues with responsiveness.
Hand-Hold Mechanism: The hold-based trigger was well-received for adding realism to the interaction, though it required fine-tuning to detect the hold duration precisely.
Application Suggestions: Users felt that proximity triggers and sound adjustments would be particularly suited to puzzle, horror, and rhythm games, adding immersive elements and soundscapes.
VR Experience Levels: Users of all experience levels interacted similarly with the triggers, though less-experienced users noted a learning curve with the hand-hold trigger.




## User Feedback

Here are the questions we asked during user testing, along with the responses we received from participants:

### How well do you think the proximity triggers worked?
- "The first one worked well, but the second one needs to be higher."
- "Worked well, not too many issues."
- "Proximity worked well with no issues; went off as expected."
- "Worked well, no issues."
- "Hand trigger might have some issues with getting within range."
- "They worked well; no issues, though the pole for the hand scanner could be higher."
- "They worked well. No glitches."

### What applications/games do you see this being used in?
- "Normal prox triggers are usable in most games. Sound bar would be good for mini-games."
- "Good for puzzle games; horror games work well with proximity triggers."
- "Useful for rhythm games with sound bars and vector speed adjustments."
- "Buttons can be used for most games; slider could serve as a UI element."
- "Exploration games, with triggers enhancing the immersion."
- "Puzzle games could benefit; proximity triggers are versatile."
- "Nothing in particular comes to mind; I don’t play many games."

### What VR experience did you have prior to this class?
- "Very minimal, mostly standard games like Super Hot and Beat Saber."
- "None."
- "Developing some VR games."
- "Very little, mostly VR sessions at friends' places with older VR setups."
- "VR arcades and exploration games. Mentioned potential motion sickness when stationary but walking in VR."
- "Limited experience, mostly with Beat Saber."
- "Minimal experience with Super Hot and other games."

## Future Considerations

Based on the feedback, the following improvements are under consideration:

- **Enhanced Range Customization**: Adjustable range detection for different trigger types.
- **Variable Trigger Placement**: Allowing customizable trigger height for a more ergonomic setup.
- **Expanded Game Application**: Investigating additional interactions for puzzle and exploration VR games to add depth and variety.
