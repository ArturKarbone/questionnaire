# Video Store

## Project statement

A simplified version of a video store which consists out of a **customer** who has a **history of movie rentals**. Based on the history a **rental statement** is being prepared. Basic unit tests are already provided (Look for **PrepareStatementTests** class).

### Challenge #1
Refactor **PrepareRentalRecordStatement** feature. Leverage **Single Responsibility Principle**. Separate data model (required to build the report) preparation from the graphical representation of the report.
### Challenge #2
Leverage **Tell, Don't Ask Principle**. Get rid of decisions based on internal entities states. Make this decision to happen within these entities
### Challenge #3
Provide a feature where an HTML version of the report being built. Cover it with unit tests.