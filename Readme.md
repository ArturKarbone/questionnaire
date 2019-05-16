Project statement: A simplified version of video store. Consists out of Customer who has a history of rentals. Based on the history a rental statement is being prepared.

1) Refactor **PrepareRentalRecordStatement** feature.
2) Leverage Single responsibility principle. Separate data model (required to build the statement) preparation from graphical representation of the report.
3) Leverage Tell, Don't ask Principle. Get rid of decicions based on internal entity states. Make this decision to happen within these entities
4) Provide a feature where an HTML version of the report being built. Cover it with unit tests