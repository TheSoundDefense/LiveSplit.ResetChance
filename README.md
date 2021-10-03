LiveSplit.ResetChance
=====================

This LiveSplit component displays the chance of the run being reset on the current split, based on historical data.

**Download:** [LiveSplit.ResetChance.dll](https://github.com/TheSoundDefense/LiveSplit.ResetChance/raw/master/Components/LiveSplit.ResetChance.dll)

To use this component, download the above DLL file and place it in the Components folder of your LiveSplit installation. This component will appear under the **Information** category.

There are three options for calculating the reset chances:

* Base reset chance on all runs - This option will take your entire run history into account.
* Base reset chance on past N runs - This option will only look at splits from the past N runs when calculating. Some later splits may have much fewer than N attempts when choosing this option.
* Base reset chance on past N attempts at current split - For every individual split, the component will look at the past N attempts at that split when calculating the reset chance.

In two instances, the component will display "?" instead of a percent value:

* The component could find no completed attempts at this split, when looking at the available values (the past N runs, or the past N split attempts).
* The split has been completed more times than the previous split has been completed. (This can happen if splits are moved from one location to another, for example.)
