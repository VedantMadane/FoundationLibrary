Namespace WebPackages.HTML

    Public NotInheritable Class EventsPacking
        Public Shared Events(31) As HTML.Structures.EventsScript
        Sub New()
#Region "Event"

            Events(0).onoma = "onerror"
            Events(0).Ellinika = "λάθος"
            Events(0).Perigrafh = "Σενάριο που εκτελείται όταν παρουσιαστεί σφάλμα"

            Events(1).onoma = "onload"
            Events(1).Ellinika = "φορτίο"
            Events(1).Perigrafh = "Ενεργοποιείται αφού ολοκληρωθεί η φόρτωση της σελίδας"

            Events(2).onoma = "onmessage"
            Events(2).Ellinika = "μήνυμα"
            Events(2).Perigrafh = "Σενάριο που θα εκτελεστεί κατά την ενεργοποίηση του μηνύματος"

            Events(3).onoma = "onpopstate"
            Events(3).Ellinika = "ιστορικό-παραθύρου"
            Events(3).Perigrafh = "Σενάριο που θα εκτελείται όταν αλλάζει το ιστορικό του παραθύρου"

            Events(4).onoma = "onstorage"
            Events(4).Ellinika = "αποθήκευσης"
            Events(4).Perigrafh = "Σενάριο που εκτελείται όταν ενημερώνεται μια περιοχή αποθήκευσης Ιστού"

            Events(5).onoma = "onblur"
            Events(5).Ellinika = "χάνει-εστίαση"
            Events(5).Perigrafh = "Πυροδοτείται τη στιγμή που το στοιχείο χάνει την εστίαση"

            Events(6).onoma = "onchange"
            Events(6).Ellinika = "αλλάζει-στοιχείο"
            Events(6).Perigrafh = "Ενεργοποιείται τη στιγμή που αλλάζει η τιμή του στοιχείου"

            Events(7).onoma = "oncontextmenu"
            Events(7).Ellinika = "μενού-περιβάλλοντος"
            Events(7).Perigrafh = "Σενάριο που εκτελείται όταν ενεργοποιείται ένα μενού περιβάλλοντος"

            Events(8).onoma = "onfocus"
            Events(8).Ellinika = "εστιάζε"
            Events(8).Perigrafh = "Πυροδοτείται τη στιγμή που το στοιχείο εστιάζε"

            Events(9).onoma = "oninput"
            Events(9).Ellinika = "εισροή"
            Events(9).Perigrafh = "Σενάριο που θα εκτελεστεί όταν ένα στοιχείο λαμβάνει είσοδο χρήστη"

            Events(10).onoma = "onkeydown"
            Events(10).Ellinika = "πατάει-πλήκτρο"
            Events(10).Perigrafh = "Ενεργοποιείται όταν ένας χρήστης πατάει ένα πλήκτρο"

            Events(11).onoma = "onkeypress"
            Events(11).Ellinika = "πατώντας-πλήκτρο"
            Events(11).Perigrafh = "Ενεργοποιείται όταν ένας χρήστης πατήσει ένα πλήκτρο"


            Events(12).onoma = "onkeyup"
            Events(12).Ellinika = "πατησε-πληκτρο"
            Events(12).Perigrafh = "Ενεργοποιείται όταν ένας χρήστης απελευθερώνει ένα κλειδί"

            Events(13).onoma = "onclick"
            Events(13).Ellinika = "κλικ"
            Events(13).Perigrafh = "Ενεργοποιείται με ένα κλικ του ποντικιού στο στοιχείο"

            Events(14).onoma = "ondblclick"
            Events(14).Ellinika = "διπλο-κλικ"
            Events(14).Perigrafh = "Ενεργοποιείται σε ένα ποντίκι κάνοντας διπλό κλικ στο στοιχείο"

            Events(15).onoma = "onmousedown"
            Events(15).Ellinika = "πατηθεί-κουμπί"
            Events(15).Perigrafh = "Ενεργοποιείται όταν πατηθεί ένα κουμπί του ποντικιού σε ένα στοιχείο"

            Events(16).onoma = "onmousemove"
            Events(16).Ellinika = "κινείται-στοιχείο"
            Events(16).Perigrafh = "Ενεργοποιείται όταν ο δείκτης του ποντικιού κινείται ενώ βρίσκεται πάνω από ένα στοιχείο"

            Events(17).onoma = "onmouseout"
            Events(17).Ellinika = "έξω-στοιχείο"
            Events(17).Perigrafh = "Ενεργοποιείται όταν ο δείκτης του ποντικιού μετακινείται έξω από ένα στοιχείο"

            Events(18).onoma = "onmouseover"
            Events(18).Ellinika = "στοιχείο- ποντικιού"
            Events(18).Perigrafh = "Ενεργοποιείται όταν ο δείκτης του ποντικιού μετακινείται πάνω από ένα στοιχείο"

            Events(19).onoma = "onmouseup"
            Events(19).Ellinika = "αφεθεί-στοιχείο"
            Events(19).Perigrafh = "Ενεργοποιείται όταν ένα κουμπί του ποντικιού αφεθεί πάνω από ένα στοιχείο"

            Events(20).onoma = "onwheel"
            Events(20).Ellinika = "τροχό-ποντικιού"
            Events(20).Perigrafh = "Πυροδοτείται όταν ο τροχός του ποντικιού κυλά πάνω ή κάτω πάνω από ένα στοιχείο"

            Events(21).onoma = "ondrag"
            Events(21).Ellinika = "σύρεται-στοιχείο"
            Events(21).Perigrafh = "Σενάριο που εκτελείται όταν σύρεται ένα στοιχείο"

            Events(22).onoma = "ondragend"
            Events(22).Ellinika = "μεταφοράς"
            Events(22).Perigrafh = "Σενάριο που θα εκτελεστεί στο τέλος μιας λειτουργίας μεταφοράς"

            Events(23).onoma = "ondragenter"
            Events(23).Ellinika = "συρθεί-απόθεσης"
            Events(23).Perigrafh = "Σενάριο που θα εκτελεστεί όταν ένα στοιχείο έχει συρθεί σε έναν έγκυρο στόχο απόθεσης"

            Events(24).onoma = "ondragleave"
            Events(24).Ellinika = "φεύγει-πτώσης"
            Events(24).Perigrafh = "Σενάριο που εκτελείται όταν ένα στοιχείο φεύγει από έναν έγκυρο στόχο πτώσης"

            Events(25).onoma = "ondragover"
            Events(25).Ellinika = "σύρεται-απόθεσης"
            Events(25).Perigrafh = "Σενάριο που εκτελείται όταν ένα στοιχείο σύρεται πάνω από έναν έγκυρο στόχο απόθεσης"

            Events(26).onoma = "ondragstart"
            Events(26).Ellinika = "έναρξη-μεταφοράς"
            Events(26).Perigrafh = "Σενάριο που θα εκτελεστεί κατά την έναρξη μιας λειτουργίας μεταφοράς"

            Events(27).onoma = "ondrop"
            Events(27).Ellinika = "απορρίπτεται-σύρεται"
            Events(27).Perigrafh = "Σενάριο που θα εκτελεστεί όταν απορρίπτεται το στοιχείο που σύρεται"

            Events(28).onoma = "onscroll"
            Events(28).Ellinika = "κύλιση"
            Events(28).Perigrafh = "Σενάριο που εκτελείται κατά την κύλιση της γραμμής κύλισης ενός στοιχείου"

            Events(29).onoma = "oncopy"
            Events(29).Ellinika = "αντιγράφει"
            Events(29).Perigrafh = "Ενεργοποιείται όταν ο χρήστης αντιγράφει το περιεχόμενο ενός στοιχείου"

            Events(30).onoma = "oncut"
            Events(30).Ellinika = "κόβει"
            Events(30).Perigrafh = "Ενεργοποιείται όταν ο χρήστης κόβει το περιεχόμενο ενός στοιχείου"

            Events(31).onoma = "onpaste"
            Events(31).Ellinika = "επικόλληση"
            Events(31).Perigrafh = "Ενεργοποιείται όταν ο χρήστης επικολλά κάποιο περιεχόμενο σε ένα στοιχείο"

#End Region
        End Sub
    End Class

End Namespace

