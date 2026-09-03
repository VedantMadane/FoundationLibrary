Namespace WebPackages.HTML
    Public NotInheritable Class AttributesPacking
        Shared ReadOnly GlobalAttributes(13) As HTML.Structures.HTMLATTRIBUTES
        Sub New()
            ReDim GlobalAttributes(0).values(0)
            ReDim GlobalAttributes(1).values(0)
            ReDim GlobalAttributes(2).values(1)
            ReDim GlobalAttributes(3).values(0)
            ReDim GlobalAttributes(4).values(2)
            ReDim GlobalAttributes(5).values(2)
            ReDim GlobalAttributes(6).values(-1)
            ReDim GlobalAttributes(7).values(0)
            ReDim GlobalAttributes(8).values(0)
            ReDim GlobalAttributes(9).values(1)
            ReDim GlobalAttributes(10).values(0)
            ReDim GlobalAttributes(11).values(0)
            ReDim GlobalAttributes(12).values(0)
            ReDim GlobalAttributes(13).values(1)

#Region "accesskey"
            GlobalAttributes(0).idiothta = "accesskey"
            GlobalAttributes(0).Eltrans = "κλειδί πρόσβασης"
            GlobalAttributes(0).Perigrafh = "Καθορίζει ένα πλήκτρο συντόμευσης για την ενεργοποίηση/εστίαση ενός στοιχείου"
            GlobalAttributes(0).syndesmos = ""

            GlobalAttributes(0).values(0).onoma = "(character)"
            GlobalAttributes(0).values(0).ellinika = "(character)"
            GlobalAttributes(0).values(0).perigrafh = "Ένας μεμονωμένος χαρακτήρας που καθορίζει το πλήκτρο συντόμευσης για την ενεργοποίηση/εστίαση του στοιχείου"
#End Region
#Region "class"
            GlobalAttributes(1).idiothta = "class"
            GlobalAttributes(1).Eltrans = "κατηγορία"
            GlobalAttributes(1).Perigrafh = "Καθορίζει ένα ή περισσότερα ονόματα κλάσεων για ένα στοιχείο (αναφέρεται σε μια κλάση σε ένα φύλλο στυλ)"
            GlobalAttributes(1).syndesmos = ""

            GlobalAttributes(1).values(0).onoma = "(classname)"
            GlobalAttributes(1).values(0).ellinika = "(classname)"
            GlobalAttributes(1).values(0).perigrafh = "Καθορίζει ένα ή περισσότερα ονόματα κλάσεων για ένα στοιχείο. Για να καθορίσετε πολλές κλάσεις, διαχωρίστε τα ονόματα των κλάσεων με ένα διάστημα, π.χ. <span class='left important'>. Αυτό σας επιτρέπει να συνδυάσετε πολλές κλάσεις CSS για ένα στοιχείο HTML. Κανόνες ονομασίας: Πρέπει να ξεκινά με ένα γράμμα A-Z ή a-z Μπορούν να ακολουθούνται από: γράμματα (A-Za-z), ψηφία (0-9), παύλες ('-') και κάτω παύλες ('_')"
#End Region
#Region "contenteditable"
            GlobalAttributes(2).idiothta = "contenteditable"
            GlobalAttributes(2).Eltrans = "ικανοποιήσιμος"
            GlobalAttributes(2).Perigrafh = "Το χαρακτηριστικό contenteditable καθορίζει εάν το περιεχόμενο ενός στοιχείου είναι επεξεργάσιμο ή όχι."
            GlobalAttributes(2).syndesmos = ""

            GlobalAttributes(2).values(0).onoma = "true"
            GlobalAttributes(2).values(0).ellinika = "αληθής"
            GlobalAttributes(2).values(0).perigrafh = "Καθορίζει ότι το στοιχείο είναι επεξεργάσιμο"


            GlobalAttributes(2).values(0).onoma = "false"
            GlobalAttributes(2).values(0).ellinika = "ψευδής"
            GlobalAttributes(2).values(0).perigrafh = "Καθορίζει ότι το στοιχείο δεν είναι επεξεργάσιμο"
#End Region
#Region "data-"
            GlobalAttributes(3).idiothta = "data-"
            GlobalAttributes(3).Eltrans = "δεδομένα-"
            GlobalAttributes(3).Perigrafh = "Τα χαρακτηριστικά data-* χρησιμοποιούνται για την αποθήκευση προσαρμοσμένων δεδομένων απόρρητα στη σελίδα ή την εφαρμογή."
            GlobalAttributes(3).syndesmos = ""

            GlobalAttributes(3).values(0).onoma = "(somevalue)"
            GlobalAttributes(3).values(0).ellinika = "(somevalue)"
            GlobalAttributes(3).values(0).perigrafh = "Καθορίζει την τιμή του χαρακτηριστικού (ως συμβολοσειρά)"
#End Region
#Region "dir"
            GlobalAttributes(4).idiothta = "dir"
            GlobalAttributes(4).Eltrans = "κατεύθυνση-κειμένου"
            GlobalAttributes(4).Perigrafh = "Το χαρακτηριστικό dir καθορίζει την κατεύθυνση κειμένου του περιεχομένου του στοιχείου."
            GlobalAttributes(4).syndesmos = ""

            GlobalAttributes(4).values(0).onoma = "ltr"
            GlobalAttributes(4).values(0).ellinika = "αριστερά-δεξιά"
            GlobalAttributes(4).values(0).perigrafh = "Προκαθορισμένο. Κατεύθυνση κειμένου από αριστερά προς τα δεξιά"

            GlobalAttributes(4).values(1).onoma = "rtl"
            GlobalAttributes(4).values(1).ellinika = "δεξιά-αριστερά"
            GlobalAttributes(4).values(1).perigrafh = "Κατεύθυνση κειμένου από δεξιά προς τα αριστερά"

            GlobalAttributes(4).values(2).onoma = "auto"
            GlobalAttributes(4).values(2).ellinika = "αυτόματο"
            GlobalAttributes(4).values(2).perigrafh = "Αφήστε το πρόγραμμα περιήγησης να καταλάβει την κατεύθυνση κειμένου, με βάση το περιεχόμενο (συνιστάται μόνο εάν η κατεύθυνση κειμένου είναι άγνωστη)"
#End Region
#Region "draggable "
            GlobalAttributes(5).idiothta = "draggable "
            GlobalAttributes(5).Eltrans = "συρθεί"
            GlobalAttributes(5).Perigrafh = "Το χαρακτηριστικό dragable καθορίζει εάν ένα στοιχείο μπορεί να συρθεί ή όχι."
            GlobalAttributes(5).syndesmos = ""

            GlobalAttributes(5).values(0).onoma = "true"
            GlobalAttributes(5).values(0).ellinika = "αληθής"
            GlobalAttributes(5).values(0).perigrafh = "Καθορίζει ότι το στοιχείο μπορεί να συρθεί"

            GlobalAttributes(5).values(1).onoma = "false"
            GlobalAttributes(5).values(1).ellinika = "ψευδής"
            GlobalAttributes(5).values(1).perigrafh = "Καθορίζει ότι το στοιχείο δεν μπορεί να συρθεί"

            GlobalAttributes(5).values(2).onoma = "auto"
            GlobalAttributes(5).values(2).ellinika = "αυτοματο"
            GlobalAttributes(5).values(2).perigrafh = "Χρησιμοποιεί την προεπιλεγμένη συμπεριφορά του προγράμματος περιήγησης"
#End Region
#Region "hidden"
            GlobalAttributes(6).idiothta = "hidden"
            GlobalAttributes(6).Eltrans = "κρυμμένο"
            GlobalAttributes(6).Perigrafh = "Όταν υπάρχει, προσδιορίζει ότι ένα στοιχείο δεν είναι ακόμη σχετικό ή δεν είναι πλέον σχετικό."
            GlobalAttributes(6).syndesmos = ""
#End Region
#Region "id"
            GlobalAttributes(7).idiothta = "id"
            GlobalAttributes(7).Eltrans = "κλειδί"
            GlobalAttributes(7).Perigrafh = "Το χαρακτηριστικό id καθορίζει ένα μοναδικό αναγνωριστικό για ένα στοιχείο HTML (η τιμή πρέπει να είναι μοναδική στο έγγραφο HTML)."
            GlobalAttributes(7).syndesmos = ""

            GlobalAttributes(7).values(0).onoma = "(id)"
            GlobalAttributes(7).values(0).ellinika = "(id)"
            GlobalAttributes(7).values(0).perigrafh = "Καθορίζει ένα μοναδικό αναγνωριστικό για το στοιχείο. Κανόνες ονομασίας: Πρέπει να περιέχει τουλάχιστον έναν χαρακτήρα Δεν πρέπει να περιέχει χαρακτήρες διαστήματος"
#End Region
#Region "lang"
            GlobalAttributes(8).idiothta = "lang"
            GlobalAttributes(8).Eltrans = "γλώσσα"
            GlobalAttributes(8).Perigrafh = "Το χαρακτηριστικό lang καθορίζει τη γλώσσα του περιεχομένου του στοιχείου."
            GlobalAttributes(8).syndesmos = ""

            GlobalAttributes(8).values(0).onoma = "(language_code)"
            GlobalAttributes(8).values(0).ellinika = "(language_code)"
            GlobalAttributes(8).values(0).perigrafh = ""
#End Region
#Region "spellcheck"
            GlobalAttributes(9).idiothta = "spellcheck "
            GlobalAttributes(9).Eltrans = "ορθογραφικός-έλεγχος"
            GlobalAttributes(9).Perigrafh = "Το χαρακτηριστικό ορθογραφικού ελέγχου καθορίζει εάν το στοιχείο θα ελέγχεται η ορθογραφία και η γραμματική του ή όχι."
            GlobalAttributes(9).syndesmos = ""

            GlobalAttributes(9).values(0).onoma = "true"
            GlobalAttributes(9).values(0).ellinika = "αληθής"
            GlobalAttributes(9).values(0).perigrafh = "Το στοιχείο είναι να ελέγχεται η ορθογραφία και η γραμματική του"

            GlobalAttributes(9).values(1).onoma = "false"
            GlobalAttributes(9).values(1).ellinika = "ψευδής"
            GlobalAttributes(9).values(1).perigrafh = "Το στοιχείο δεν πρέπει να ελεγχθε"
#End Region
#Region "style"
            GlobalAttributes(10).idiothta = "style"
            GlobalAttributes(10).Eltrans = "στυλ"
            GlobalAttributes(10).Perigrafh = "Το χαρακτηριστικό style καθορίζει ένα ενσωματωμένο στυλ για ένα στοιχείο."
            GlobalAttributes(10).syndesmos = ""

            GlobalAttributes(10).values(0).onoma = "(style_definitions)"
            GlobalAttributes(10).values(0).ellinika = "(style_definitions)"
            GlobalAttributes(10).values(0).perigrafh = "Μία ή περισσότερες ιδιότητες και τιμές CSS διαχωρισμένες με ερωτηματικά (π.χ. style='color:blue;text-align:center')"
#End Region
#Region "tabindex"
            GlobalAttributes(11).idiothta = "tabindex"
            GlobalAttributes(11).Eltrans = "ευρετήριο-καρτελών"
            GlobalAttributes(11).Perigrafh = "Το χαρακτηριστικό tabindex καθορίζει τη σειρά καρτελών ενός στοιχείου (όταν το κουμπί 'tab' χρησιμοποιείται για πλοήγηση)."
            GlobalAttributes(11).syndesmos = ""

            GlobalAttributes(11).values(0).onoma = "(number)"
            GlobalAttributes(11).values(0).ellinika = "(number)"
            GlobalAttributes(11).values(0).perigrafh = "Καθορίζει τη σειρά καρτέλας του στοιχείου (το 1 είναι το πρώτο)"
#End Region
#Region "title"
            GlobalAttributes(12).idiothta = "title"
            GlobalAttributes(12).Eltrans = "τίτλος"
            GlobalAttributes(12).Perigrafh = "Το χαρακτηριστικό title καθορίζει επιπλέον πληροφορίες για ένα στοιχείο"
            GlobalAttributes(12).syndesmos = ""

            GlobalAttributes(12).values(0).onoma = "(text)"
            GlobalAttributes(12).values(0).ellinika = "(text)"
            GlobalAttributes(12).values(0).perigrafh = "Ένα κείμενο συμβουλής εργαλείου για ένα στοιχείο"
#End Region
#Region "translate"
            GlobalAttributes(13).idiothta = "translate"
            GlobalAttributes(13).Eltrans = "μεταφράζω"
            GlobalAttributes(13).Perigrafh = "Το χαρακτηριστικό translate καθορίζει εάν το περιεχόμενο ενός στοιχείου πρέπει να μεταφραστεί ή όχι."
            GlobalAttributes(13).syndesmos = ""

            GlobalAttributes(13).values(0).onoma = "yes"
            GlobalAttributes(13).values(0).ellinika = "Ναί"
            GlobalAttributes(13).values(0).perigrafh = "Καθορίζει ότι το περιεχόμενο του στοιχείου πρέπει να μεταφραστεί"

            GlobalAttributes(13).values(0).onoma = "no"
            GlobalAttributes(13).values(0).ellinika = "όχι"
            GlobalAttributes(13).values(0).perigrafh = "Καθορίζει ότι το περιεχόμενο του στοιχείου δεν πρέπει να μεταφραστεί"
#End Region
        End Sub
    End Class

End Namespace

