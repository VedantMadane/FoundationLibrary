Namespace WebPackages.HTML


    Public NotInheritable Class HTMLPACKING

        Public packHTML(109) As HTML.Structures.HTMLTAG
        Sub New()


#Region "Σχόλιο"
            ReDim packHTML(0).HTMLIDIOTHTES(-1)
            ReDim packHTML(0).GlobalAttributes(-1)
            packHTML(0).Etiketa = "<!-- --->"
            packHTML(0).onomasia = "Σχόλιο"
            packHTML(0).ELtrans = "<!-- --->"
            packHTML(0).Perigrafh = "Ορίζει ένα σχόλιο"
            ' packHTML(0).Syndesmos = My.Resources.Σχολιο
#End Region
#Region "<!DOCTYPE>"
            ReDim packHTML(1).HTMLIDIOTHTES(-1)
            ReDim packHTML(1).GlobalAttributes(-1)
            packHTML(1).Etiketa = "<!DOCTYPE>"
            packHTML(1).onomasia = "Έκδοση HTML5"
            packHTML(1).ELtrans = "<!Έκδοση>"
            packHTML(1).Perigrafh = "Καθορίζει τον τύπο του εγγράφου"
            ' packHTML(1).Syndesmos = My.Resources.doctype
#End Region
#Region "<a>"
            ReDim packHTML(2).HTMLIDIOTHTES(8)
            ReDim packHTML(2).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(2).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(2).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(2).HTMLIDIOTHTES(3).values(24)
            ReDim packHTML(2).HTMLIDIOTHTES(4).values(0)
            ReDim packHTML(2).HTMLIDIOTHTES(5).values(6)
            ReDim packHTML(2).HTMLIDIOTHTES(6).values(12)
            ReDim packHTML(2).HTMLIDIOTHTES(7).values(4)
            ReDim packHTML(2).HTMLIDIOTHTES(8).values(0)

            '------- TAG--------'
            packHTML(2).Etiketa = "<a>"
            packHTML(2).onomasia = "Σύνδεσμος"
            packHTML(2).ELtrans = "<Σύνδεσμος>"
            packHTML(2).Perigrafh = "Ορίζει μια υπερσύνδεση"
            '  packHTML(2).Syndesmos = My.Resources.a
#Region "attribute"
            '---------- ATTRIBUTES Download---------'
            packHTML(2).HTMLIDIOTHTES(0).idiothta = "download"
            packHTML(2).HTMLIDIOTHTES(0).Eltrans = "Κατέβασμα"
            packHTML(2).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι ο στόχος θα ληφθεί όταν ένας χρήστης κάνει κλικ στον υπερσύνδεσμο"
            packHTML(2).HTMLIDIOTHTES(0).syndesmos = ""
            '---------- ATTRIBUTES href---------'
            packHTML(2).HTMLIDIOTHTES(1).idiothta = "href"
            packHTML(2).HTMLIDIOTHTES(1).Eltrans = "Σύνδεσμος"
            packHTML(2).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει τη διεύθυνση URL της σελίδας στην οποία μεταβαίνει ο σύνδεσμος"
            packHTML(2).HTMLIDIOTHTES(1).syndesmos = ""
            '---------- ATTRIBUTES hreflang---------'
            packHTML(2).HTMLIDIOTHTES(2).idiothta = "hreflang"
            packHTML(2).HTMLIDIOTHTES(2).Eltrans = "Γλώσσα"
            packHTML(2).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει τη γλώσσα του συνδεδεμένου εγγράφου"
            packHTML(2).HTMLIDIOTHTES(2).syndesmos = ""
            '---------- ATTRIBUTES media---------'
            packHTML(2).HTMLIDIOTHTES(3).idiothta = "media"
            packHTML(2).HTMLIDIOTHTES(3).Eltrans = "Συσκευή"
            packHTML(2).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει για ποια μέσα/συσκευή έχει βελτιστοποιηθεί το συνδεδεμένο έγγραφο"
            packHTML(2).HTMLIDIOTHTES(3).syndesmos = ""
            '---------- ATTRIBUTES ping---------'
            packHTML(2).HTMLIDIOTHTES(4).idiothta = "ping"
            packHTML(2).HTMLIDIOTHTES(4).Eltrans = "ΠΙΝΚ"
            packHTML(2).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει μια λίστα διευθύνσεων URL χωρισμένη σε διάστημα, στις οποίες, όταν ακολουθείται ο σύνδεσμος, θα αποστέλλονται αιτήματα ανάρτησης με το σώμα ping από το πρόγραμμα περιήγησης (στο παρασκήνιο). Συνήθως χρησιμοποιείται για παρακολούθηση."
            packHTML(2).HTMLIDIOTHTES(4).syndesmos = ""
            '---------- ATTRIBUTES referrerpolicy---------'
            packHTML(2).HTMLIDIOTHTES(5).idiothta = "referrerpolicy"
            packHTML(2).HTMLIDIOTHTES(5).Eltrans = "πολιτική-παραπομπής"
            packHTML(2).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει ποιες πληροφορίες παραπομπής θα αποστέλλονται με τον σύνδεσμο."
            packHTML(2).HTMLIDIOTHTES(5).syndesmos = ""
            '---------- ATTRIBUTES rel---------'
            packHTML(2).HTMLIDIOTHTES(6).idiothta = "rel"
            packHTML(2).HTMLIDIOTHTES(6).Eltrans = "σχετικά"
            packHTML(2).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει τη σχέση μεταξύ του τρέχοντος εγγράφου και του συνδεδεμένου εγγράφου."
            packHTML(2).HTMLIDIOTHTES(6).syndesmos = ""
            '---------- ATTRIBUTES target---------'
            packHTML(2).HTMLIDIOTHTES(7).idiothta = "target"
            packHTML(2).HTMLIDIOTHTES(7).Eltrans = "στόχος"
            packHTML(2).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει πού θα ανοίξει το συνδεδεμένο έγγραφο"
            packHTML(2).HTMLIDIOTHTES(7).syndesmos = ""
            '---------- ATTRIBUTES type---------'
            packHTML(2).HTMLIDIOTHTES(8).idiothta = "type"
            packHTML(2).HTMLIDIOTHTES(8).Eltrans = "τύπος"
            packHTML(2).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει τον τύπο μέσου του συνδεδεμένου εγγράφου"
            packHTML(2).HTMLIDIOTHTES(8).syndesmos = ""
#End Region
#Region "VALUES"


            '---------- VALUE Download -------------'
            packHTML(2).HTMLIDIOTHTES(0).values(0).onoma = "filename"
            packHTML(2).HTMLIDIOTHTES(0).values(0).ellinika = "Όνομα Αρχείου"
            packHTML(2).HTMLIDIOTHTES(0).values(0).perigrafh = "Προαιρετικός. Καθορίζει το νέο όνομα αρχείου για το ληφθέν αρχείο"
            '---------- VALUE href -------------'
            packHTML(2).HTMLIDIOTHTES(1).values(0).onoma = "URL"
            packHTML(2).HTMLIDIOTHTES(1).values(0).ellinika = "URL"
            packHTML(2).HTMLIDIOTHTES(1).values(0).perigrafh = "The URL of the link.
Possible values:

-An absolute URL - points to another web site (like href='http://www.example.com/default.htm')
    A relative URL - points to a file within a web site (like href='default.htm')
-Link to an element with a specified id within the page (like href='#section2')
-Other protocols (like https://, ftp://, mailto:, file:, etc..)
-A script (like href='javascript:alert('Hello');')"
            '---------- VALUE hreflang -------------'
            packHTML(2).HTMLIDIOTHTES(2).values(0).onoma = "(language_code)"
            packHTML(2).HTMLIDIOTHTES(2).values(0).ellinika = "(Γλώσαα)"
            packHTML(2).HTMLIDIOTHTES(2).values(0).perigrafh = "Ένας κωδικός γλώσσας δύο γραμμάτων που καθορίζει τη γλώσσα του συνδεδεμένου εγγράφου. 
Για να δείτε όλους τους διαθέσιμους κωδικούς γλώσσας, μεταβείτε στην αναφορά κωδικών γλώσσας."
            '---------- VALUE media Operators and -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(0).onoma = "and"
            packHTML(2).HTMLIDIOTHTES(3).values(0).ellinika = "και"
            packHTML(2).HTMLIDIOTHTES(3).values(0).perigrafh = "Καθορίζει έναν τελεστή ΚΑΙ(AND)"
            '---------- VALUE media Operators not -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(1).onoma = "not"
            packHTML(2).HTMLIDIOTHTES(3).values(1).ellinika = "Δεν"
            packHTML(2).HTMLIDIOTHTES(3).values(1).perigrafh = "Καθορίζει έναν τελεστή ΔΕΝ(NOT)"
            '---------- VALUE media Operators , -------------'        
            packHTML(2).HTMLIDIOTHTES(3).values(2).onoma = ","
            packHTML(2).HTMLIDIOTHTES(3).values(2).ellinika = ","
            packHTML(2).HTMLIDIOTHTES(3).values(3).perigrafh = "Καθορίζει έναν τελεστή Η(OR)"
            '---------- VALUE media Devices all -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(3).onoma = "all"
            packHTML(2).HTMLIDIOTHTES(3).values(3).ellinika = "Όλες"
            packHTML(2).HTMLIDIOTHTES(3).values(3).perigrafh = "Προκαθορισμένο. Κατάλληλο για όλες τις συσκευές"
            '---------- VALUE media Devices aural -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(4).onoma = "aural"
            packHTML(2).HTMLIDIOTHTES(3).values(4).ellinika = "ομιλίας"
            packHTML(2).HTMLIDIOTHTES(3).values(4).perigrafh = "Συνθεσάιζερ ομιλίας"
            '---------- VALUE media Devices braile -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(5).onoma = "braile"
            packHTML(2).HTMLIDIOTHTES(3).values(5).ellinika = "τυφλών"
            packHTML(2).HTMLIDIOTHTES(3).values(5).perigrafh = "Συσκευές ανάδρασης Braille"
            '---------- VALUE media Devices handheld -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(6).onoma = "handheld"
            packHTML(2).HTMLIDIOTHTES(3).values(6).ellinika = "χειρός"
            packHTML(2).HTMLIDIOTHTES(3).values(6).perigrafh = "handheld"
            '---------- VALUE media Devices projection -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(7).onoma = "projection"
            packHTML(2).HTMLIDIOTHTES(3).values(7).ellinika = "Προβολείς"
            packHTML(2).HTMLIDIOTHTES(3).values(7).perigrafh = "Προβολείς"
            '---------- VALUE media Devices print -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(8).onoma = "print"
            packHTML(2).HTMLIDIOTHTES(3).values(8).ellinika = "Τυπώνω"
            packHTML(2).HTMLIDIOTHTES(3).values(8).perigrafh = "Λειτουργία προεπισκόπησης εκτύπωσης/εκτυπωμένες σελίδες"
            '---------- VALUE media Devices screen -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(9).onoma = "screen"
            packHTML(2).HTMLIDIOTHTES(3).values(9).ellinika = "Οθόνες"
            packHTML(2).HTMLIDIOTHTES(3).values(9).perigrafh = "Οθόνες υπολογιστών"
            '---------- VALUE media Devices tty -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(10).onoma = "tty"
            packHTML(2).HTMLIDIOTHTES(3).values(10).ellinika = "Τηλέτυποι"
            packHTML(2).HTMLIDIOTHTES(3).values(10).perigrafh = "Τηλέτυποι και παρόμοια μέσα που χρησιμοποιούν πλέγμα χαρακτήρων σταθερού τόνου"
            '---------- VALUE media Devices tv -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(11).onoma = "tv"
            packHTML(2).HTMLIDIOTHTES(3).values(11).ellinika = "τηλεόρασης"
            packHTML(2).HTMLIDIOTHTES(3).values(11).perigrafh = "Συσκευές τύπου τηλεόρασης (χαμηλή ανάλυση, περιορισμένη δυνατότητα κύλισης)"
            '---------- VALUE media Values width -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(12).onoma = "width"
            packHTML(2).HTMLIDIOTHTES(3).values(12).ellinika = "πλάτος"
            packHTML(2).HTMLIDIOTHTES(3).values(12).perigrafh = "Καθορίζει το πλάτος της στοχευμένης περιοχής εμφάνισης. 
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (min-width:500px)'"
            '---------- VALUE media Values height -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(13).onoma = "height"
            packHTML(2).HTMLIDIOTHTES(3).values(13).ellinika = "ύψος"
            packHTML(2).HTMLIDIOTHTES(3).values(13).perigrafh = "Καθορίζει το ύψος της  στοχευμένης περιοχής προβολής.
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (max-height:700px)'"
            '---------- VALUE media Values device-width -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(14).onoma = "device-width"
            packHTML(2).HTMLIDIOTHTES(3).values(14).ellinika = "πλάτος-συσκευής"
            packHTML(2).HTMLIDIOTHTES(3).values(14).perigrafh = "Καθορίζει το πλάτος της οθόνης/χαρτιού στόχου. 
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (device-width:500px)'"
            '---------- VALUE media Values device-height -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(15).onoma = "device-height"
            packHTML(2).HTMLIDIOTHTES(3).values(15).ellinika = "ύψος-συσκευής"
            packHTML(2).HTMLIDIOTHTES(3).values(15).perigrafh = "Καθορίζει το ύψος της οθόνης/χαρτιού στόχου. 
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (device-height:500px)'"
            '---------- VALUE media Values orientation -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(16).onoma = "orientation"
            packHTML(2).HTMLIDIOTHTES(3).values(16).ellinika = "προσανατολισμός"
            packHTML(2).HTMLIDIOTHTES(3).values(16).perigrafh = "Καθορίζει τον προσανατολισμό της οθόνης/χαρτιού προορισμού.
Πιθανές τιμές: 'πορτραίτο' ή 'τοπίο' Παράδειγμα: media='all and (orientation: landscape)'"
            '---------- VALUE media Values aspect-ratio -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(17).onoma = "aspect-ratio"
            packHTML(2).HTMLIDIOTHTES(3).values(17).ellinika = "αναλογία-απεικόνισης"
            packHTML(2).HTMLIDIOTHTES(3).values(17).perigrafh = "Καθορίζει την αναλογία πλάτους/ύψους της στοχευόμενης περιοχής εμφάνισης.
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (aspect-ratio:16/9)'"
            '---------- VALUE media Values device-aspect-ratio -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(18).onoma = "device-aspect-ratio"
            packHTML(2).HTMLIDIOTHTES(3).values(18).ellinika = "αναλογία-συσκευής"
            packHTML(2).HTMLIDIOTHTES(3).values(18).perigrafh = "Καθορίζει την αναλογία πλάτους συσκευής/ύψους συσκευής της οθόνης/χαρτιού στόχου.
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (aspect-ratio:16/9)'"
            '---------- VALUE media Values color -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(19).onoma = "color"
            packHTML(2).HTMLIDIOTHTES(3).values(19).ellinika = "χρώμα"
            packHTML(2).HTMLIDIOTHTES(3).values(19).perigrafh = "Καθορίζει τα bit ανά χρώμα της οθόνης προορισμού. 
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (color:3)"
            '---------- VALUE media Values color-index -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(20).onoma = "color-index"
            packHTML(2).HTMLIDIOTHTES(3).values(20).ellinika = "δείκτης-χρώματος"
            packHTML(2).HTMLIDIOTHTES(3).values(20).perigrafh = "color-indexΚαθορίζει τον αριθμό των χρωμάτων που μπορεί να χειριστεί η οθόνη προορισμού.
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (min-color-index:256)'"
            '---------- VALUE media Values monochrome -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(21).onoma = "monochrome"
            packHTML(2).HTMLIDIOTHTES(3).values(21).ellinika = "μονόχρωμος"
            packHTML(2).HTMLIDIOTHTES(3).values(21).perigrafh = "Καθορίζει τα bit ανά εικονοστοιχείο σε μια προσωρινή μνήμη μονόχρωμου πλαισίου.
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='screen and (monochrome:2)'"
            '---------- VALUE media Values resolution -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(22).onoma = "resolution"
            packHTML(2).HTMLIDIOTHTES(3).values(22).ellinika = "ανάλυση"
            packHTML(2).HTMLIDIOTHTES(3).values(22).perigrafh = "Καθορίζει την πυκνότητα pixel (dpi ή dpcm) της οθόνης/χαρτιού στόχου.
Μπορούν να χρησιμοποιηθούν τα προθέματα 'min-' και 'max-'. Παράδειγμα: media='print and (ανάλυση:300dpi)'"
            '---------- VALUE media Values scan -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(23).onoma = "scan"
            packHTML(2).HTMLIDIOTHTES(3).values(23).ellinika = "σάρωση"
            packHTML(2).HTMLIDIOTHTES(3).values(23).perigrafh = "Καθορίζει τη μέθοδο σάρωσης μιας οθόνης τηλεόρασης. Πιθανές τιμές είναι 'progressive' και 'interlace'.
Παράδειγμα: media='tv and (scan:interlace)'"
            '---------- VALUE media Values grid -------------'
            packHTML(2).HTMLIDIOTHTES(3).values(24).onoma = "grid"
            packHTML(2).HTMLIDIOTHTES(3).values(24).ellinika = "πλέγμα"
            packHTML(2).HTMLIDIOTHTES(3).values(24).perigrafh = "Καθορίζει εάν η συσκευή εξόδου είναι πλέγμα ή bitmap. Οι πιθανές τιμές είναι '1' για το πλέγμα και '0' διαφορετικά.
Παράδειγμα: media='handheld and (grid:1)'"
            '---------- VALUE ping  -------------'
            packHTML(2).HTMLIDIOTHTES(4).values(0).onoma = "URL"
            packHTML(2).HTMLIDIOTHTES(4).values(0).ellinika = "URL"
            packHTML(2).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL που θα ειδοποιηθεί εάν ο χρήστης ακολουθήσει τον υπερσύνδεσμο. 
Πρέπει να είναι μια λίστα διαχωρισμένη με κενό διάστημα με μία ή περισσότερες έγκυρες διευθύνσεις URL"
            '---------- VALUE referrerpolicy no-referrer  -------------'
            packHTML(2).HTMLIDIOTHTES(5).values(0).onoma = "no-referrer"
            packHTML(2).HTMLIDIOTHTES(5).values(0).ellinika = "χωρίς-παραπομπή"
            packHTML(2).HTMLIDIOTHTES(5).values(0).perigrafh = "Δεν αποστέλλονται πληροφορίες παραπομπής"
            '---------- VALUE referrerpolicy no-referrer-when-downgrade  -------------'
            packHTML(2).HTMLIDIOTHTES(5).values(1).onoma = "no-referrer-when-downgrade"
            packHTML(2).HTMLIDIOTHTES(5).values(1).ellinika = "χωρίς-παραπομπή-όποτε-κατηφόρα"
            packHTML(2).HTMLIDIOTHTES(5).values(1).perigrafh = "Προκαθορισμένο. Στέλνει την προέλευση, τη διαδρομή και τη συμβολοσειρά ερωτήματος εάν το επίπεδο ασφάλειας του πρωτοκόλλου παραμένει το ίδιο ή είναι υψηλότερο (HTTP σε HTTP, HTTPS σε HTTPS, HTTP σε HTTPS είναι εντάξει). Δεν στέλνει τίποτα σε λιγότερο ασφαλές επίπεδο (το HTTPS σε HTTP δεν είναι εντάξει)"
            '---------- VALUE referrerpolicy origin  -------------'
            packHTML(2).HTMLIDIOTHTES(5).values(2).onoma = "origin"
            packHTML(2).HTMLIDIOTHTES(5).values(2).ellinika = "προέλευση"
            packHTML(2).HTMLIDIOTHTES(5).values(2).perigrafh = "Στέλνει την προέλευση (σχήμα, κεντρικό υπολογιστή και θύρα) του εγγράφου"
            '---------- VALUE referrerpolicy origin-when-cross-origin  -------------'
            packHTML(2).HTMLIDIOTHTES(5).values(3).onoma = "origin-when-cross-origin"
            packHTML(2).HTMLIDIOTHTES(5).values(3).ellinika = "προέλευση-όταν-διασταυρούμενη-καταγωγή"
            packHTML(2).HTMLIDIOTHTES(5).values(3).perigrafh = "Στέλνει την προέλευση του εγγράφου για αίτημα διασταυρούμενης προέλευσης. Στέλνει την προέλευση, τη διαδρομή και τη συμβολοσειρά ερωτήματος για αίτημα ίδιας προέλευσης"
            '---------- VALUE referrerpolicy same-origin  -------------'
            packHTML(2).HTMLIDIOTHTES(5).values(4).onoma = "same-origin"
            packHTML(2).HTMLIDIOTHTES(5).values(4).ellinika = "ίδιας-καταγωγής"
            packHTML(2).HTMLIDIOTHTES(5).values(4).perigrafh = "Στέλνει έναν παραπομπή για αίτημα ίδιας προέλευσης. Δεν στέλνει παραπομπή για αίτημα διασταυρούμενης προέλευσης"
            '---------- VALUE referrerpolicy strict-origin-when-cross-origin  -------------'
            packHTML(2).HTMLIDIOTHTES(5).values(5).onoma = "strict-origin-when-cross-origin"
            packHTML(2).HTMLIDIOTHTES(5).values(5).ellinika = "αυστηρή-προέλευση-όταν-διασταυρούμενη-προέλευση"
            packHTML(2).HTMLIDIOTHTES(5).values(5).perigrafh = "Στέλνει την αρχή εάν το επίπεδο ασφάλειας του πρωτοκόλλου παραμένει το ίδιο ή είναι υψηλότερο (HTTP σε HTTP, HTTPS σε HTTPS και HTTP σε HTTPS είναι εντάξει). 
Δεν στέλνει τίποτα σε λιγότερο ασφαλές επίπεδο (HTTPS σε HTTP)"
            '---------- VALUE referrerpolicy unsafe-url  -------------'
            packHTML(2).HTMLIDIOTHTES(5).values(6).onoma = "unsafe-url"
            packHTML(2).HTMLIDIOTHTES(5).values(6).ellinika = "επισφαλής-προέλευση"
            packHTML(2).HTMLIDIOTHTES(5).values(6).perigrafh = "Στέλνει την προέλευση, τη διαδρομή και τη συμβολοσειρά ερωτήματος (ανεξαρτήτως ασφάλειας). 
Χρησιμοποιήστε αυτή την τιμή προσεκτικά!"
            '---------- VALUE rel alternate  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(0).onoma = "alternate"
            packHTML(2).HTMLIDIOTHTES(6).values(0).ellinika = "εναλλακτικό"
            packHTML(2).HTMLIDIOTHTES(6).values(0).perigrafh = "Παρέχει έναν σύνδεσμο προς μια εναλλακτική αναπαράσταση του εγγράφου (π.χ. σελίδα εκτύπωσης, μετάφραση ή καθρέφτης)"
            '---------- VALUE rel author  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(1).onoma = "author"
            packHTML(2).HTMLIDIOTHTES(6).values(1).ellinika = "συγγραφέας"
            packHTML(2).HTMLIDIOTHTES(6).values(1).perigrafh = "Παρέχει έναν σύνδεσμο προς τον συντάκτη του εγγράφου"
            '---------- VALUE rel bookmark  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(2).onoma = "bookmark"
            packHTML(2).HTMLIDIOTHTES(6).values(2).ellinika = "σελιδοδείκτη"
            packHTML(2).HTMLIDIOTHTES(6).values(2).perigrafh = "Μόνιμη διεύθυνση URL που χρησιμοποιείται για σελιδοδείκτη"
            '---------- VALUE rel external  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(3).onoma = "external"
            packHTML(2).HTMLIDIOTHTES(6).values(3).ellinika = "εξωτερικός"
            packHTML(2).HTMLIDIOTHTES(6).values(3).perigrafh = "Υποδεικνύει ότι το έγγραφο αναφοράς δεν αποτελεί μέρος της ίδιας τοποθεσίας με το τρέχον έγγραφο"
            '---------- VALUE rel help  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(4).onoma = "help"
            packHTML(2).HTMLIDIOTHTES(6).values(4).ellinika = "βοήθεια"
            packHTML(2).HTMLIDIOTHTES(6).values(4).perigrafh = "Παρέχει έναν σύνδεσμο προς ένα έγγραφο βοήθειας"
            '---------- VALUE rel license  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(5).onoma = "license"
            packHTML(2).HTMLIDIOTHTES(6).values(5).ellinika = "άδεια"
            packHTML(2).HTMLIDIOTHTES(6).values(5).perigrafh = "Παρέχει μια σύνδεση με πληροφορίες αδειοδότησης για το έγγραφο"
            '---------- VALUE rel next  ------------'
            packHTML(2).HTMLIDIOTHTES(6).values(6).onoma = "next"
            packHTML(2).HTMLIDIOTHTES(6).values(6).ellinika = "Επόμενο"
            packHTML(2).HTMLIDIOTHTES(6).values(6).perigrafh = "Παρέχει έναν σύνδεσμο προς το επόμενο έγγραφο της σειράς"
            '---------- VALUE rel nofollow  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(7).onoma = "nofollow"
            packHTML(2).HTMLIDIOTHTES(6).values(7).ellinika = "γκακολουθηστε"
            packHTML(2).HTMLIDIOTHTES(6).values(7).perigrafh = "Σύνδεσμοι σε μη εγκεκριμένο έγγραφο, όπως σύνδεσμος επί πληρωμή. (Το 'nofollow' χρησιμοποιείται από την Google, για να προσδιορίσει ότι η αράχνη αναζήτησης Google δεν πρέπει να ακολουθεί αυτόν τον σύνδεσμο)"
            '---------- VALUE rel noopener	  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(8).onoma = "noopener	"
            packHTML(2).HTMLIDIOTHTES(6).values(8).ellinika = "ανοιχτήρι"
            packHTML(2).HTMLIDIOTHTES(6).values(8).perigrafh = "Απαιτεί ότι οποιοδήποτε περιβάλλον περιήγησης που δημιουργείται ακολουθώντας την υπερ-σύνδεση δεν πρέπει να έχει ανοιχτό περιβάλλον περιήγησης"
            '---------- VALUE rel noreferrer	  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(9).onoma = "noreferrer	"
            packHTML(2).HTMLIDIOTHTES(6).values(9).ellinika = "κανένας-παραπέμπων"
            packHTML(2).HTMLIDIOTHTES(6).values(9).perigrafh = "Κάνει τον παραπέμποντα άγνωστο. Δεν θα συμπεριληφθεί κεφαλίδα παραπομπής όταν ο χρήστης κάνει κλικ στον υπερσύνδεσμο"
            '---------- VALUE rel prev	  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(10).onoma = "prev"
            packHTML(2).HTMLIDIOTHTES(6).values(10).ellinika = "προηγούμενο"
            packHTML(2).HTMLIDIOTHTES(6).values(10).perigrafh = "Το προηγούμενο έγγραφο σε μια επιλογή"
            '---------- VALUE rel search	  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(11).onoma = "search"
            packHTML(2).HTMLIDIOTHTES(6).values(11).ellinika = "Αναζήτηση"
            packHTML(2).HTMLIDIOTHTES(6).values(11).perigrafh = "Σύνδεσμοι σε ένα εργαλείο αναζήτησης για το έγγραφο"
            '---------- VALUE rel tag	  -------------'
            packHTML(2).HTMLIDIOTHTES(6).values(12).onoma = "tag"
            packHTML(2).HTMLIDIOTHTES(6).values(12).ellinika = "ετικέτα"
            packHTML(2).HTMLIDIOTHTES(6).values(12).perigrafh = "Μια ετικέτα (λέξη-κλειδί) για το τρέχον έγγραφο"
            '---------- VALUE target _blank	  -------------'
            packHTML(2).HTMLIDIOTHTES(7).values(0).onoma = "_blank"
            packHTML(2).HTMLIDIOTHTES(7).values(0).ellinika = "_κενό"
            packHTML(2).HTMLIDIOTHTES(7).values(0).perigrafh = "Ανοίγει το συνδεδεμένο έγγραφο σε νέο παράθυρο ή καρτέλα"
            '---------- VALUE target _self	  -------------'
            packHTML(2).HTMLIDIOTHTES(7).values(1).onoma = "_self"
            packHTML(2).HTMLIDIOTHTES(7).values(1).ellinika = "_εαυτός"
            packHTML(2).HTMLIDIOTHTES(7).values(1).perigrafh = "Ανοίγει το συνδεδεμένο έγγραφο στο ίδιο πλαίσιο με το οποίο έγινε κλικ (αυτό είναι προεπιλεγμένο)"
            '---------- VALUE target _parent	  -------------'
            packHTML(2).HTMLIDIOTHTES(7).values(2).onoma = "_parent"
            packHTML(2).HTMLIDIOTHTES(7).values(2).ellinika = "_μητρική"
            packHTML(2).HTMLIDIOTHTES(7).values(2).perigrafh = "Ανοίγει το συνδεδεμένο έγγραφο στο γονικό πλαίσιο"
            '---------- VALUE target _top	  -------------'
            packHTML(2).HTMLIDIOTHTES(7).values(3).onoma = "_top"
            packHTML(2).HTMLIDIOTHTES(7).values(3).ellinika = "_κορυφή"
            packHTML(2).HTMLIDIOTHTES(7).values(3).perigrafh = "Ανοίγει το συνδεδεμένο έγγραφο σε ολόκληρο το σώμα του παραθύρου"
            '---------- VALUE target framename	  -------------'
            packHTML(2).HTMLIDIOTHTES(7).values(4).onoma = "(framename)"
            packHTML(2).HTMLIDIOTHTES(7).values(4).ellinika = "(επώνυμο)"
            packHTML(2).HTMLIDIOTHTES(7).values(4).perigrafh = "Ανοίγει το συνδεδεμένο έγγραφο στο επώνυμο iframe"
            '---------- VALUE type media_type	  -------------'
            packHTML(2).HTMLIDIOTHTES(8).values(0).onoma = "(media_type)"
            packHTML(2).HTMLIDIOTHTES(8).values(0).ellinika = "(Τύπος πολυμέσων)"
            packHTML(2).HTMLIDIOTHTES(8).values(0).perigrafh = "Ο τύπος μέσων Διαδικτύου του συνδεδεμένου εγγράφου. Ανατρέξτε στο IANA Media Types για μια πλήρη λίστα με τυπικούς τύπους μέσων."
#End Region
#End Region
#Region "<abbr>"
            ReDim packHTML(3).HTMLIDIOTHTES(-1)


            packHTML(3).Etiketa = "<abbr>"
            packHTML(3).onomasia = "συντομογραφία"
            packHTML(3).ELtrans = "<συντομογραφία>"
            packHTML(3).Perigrafh = "Ορίζει μια συντομογραφία ή ένα αρκτικόλεξο"
            ' packHTML(3).Syndesmos = My.Resources.abbr
#End Region
#Region "<address>"
            ReDim packHTML(4).HTMLIDIOTHTES(-1)

            packHTML(4).Etiketa = "<address>"
            packHTML(4).onomasia = "επικοινωνία"
            packHTML(4).ELtrans = "<επικοινωνία>"
            packHTML(4).Perigrafh = "Καθορίζει τα στοιχεία επικοινωνίας για τον συγγραφέα/κάτοχο ενός εγγράφου"
            ' packHTML(4).Syndesmos = My.Resources.address
#End Region
#Region "<area>"
            ReDim packHTML(5).HTMLIDIOTHTES(10)
            ReDim packHTML(5).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(5).HTMLIDIOTHTES(1).values(2)
            ReDim packHTML(5).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(5).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(5).HTMLIDIOTHTES(4).values(0)
            ReDim packHTML(5).HTMLIDIOTHTES(5).values(24)
            ReDim packHTML(5).HTMLIDIOTHTES(6).values(7)
            ReDim packHTML(5).HTMLIDIOTHTES(7).values(11)
            ReDim packHTML(5).HTMLIDIOTHTES(8).values(3)
            ReDim packHTML(5).HTMLIDIOTHTES(9).values(4)
            ReDim packHTML(5).HTMLIDIOTHTES(10).values(0)

            packHTML(5).Etiketa = "<area>"
            packHTML(5).onomasia = "περιοχή"
            packHTML(5).ELtrans = "<περιοχή>"
            packHTML(5).Perigrafh = "Καθορίζει μια περιοχή μέσα σε έναν χάρτη εικόνας"
            ' packHTML(5).Syndesmos = My.Resources.area
            '----------ATTRIBUTES alt -------'
            packHTML(5).HTMLIDIOTHTES(0).idiothta = "alt"
            packHTML(5).HTMLIDIOTHTES(0).Eltrans = "εναλλακτικό"
            packHTML(5).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ένα εναλλακτικό κείμενο για την περιοχή. Απαιτείται εάν υπάρχει το χαρακτηριστικό href"
            packHTML(5).HTMLIDIOTHTES(0).syndesmos = ""
            '----------ATTRIBUTES coords -------'
            packHTML(5).HTMLIDIOTHTES(1).idiothta = "coords"
            packHTML(5).HTMLIDIOTHTES(1).Eltrans = "συντεταγμένες"
            packHTML(5).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει τις συντεταγμένες της περιοχής"
            packHTML(5).HTMLIDIOTHTES(1).syndesmos = ""
            '----------ATTRIBUTES download -------'
            packHTML(5).HTMLIDIOTHTES(2).idiothta = "download"
            packHTML(5).HTMLIDIOTHTES(2).Eltrans = "Κατεβάστε"
            packHTML(5).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει ότι ο στόχος θα ληφθεί όταν ένας χρήστης κάνει κλικ στον υπερσύνδεσμο"
            packHTML(5).HTMLIDIOTHTES(2).syndesmos = ""
            '----------ATTRIBUTES href -------'
            packHTML(5).HTMLIDIOTHTES(3).idiothta = "href"
            packHTML(5).HTMLIDIOTHTES(3).Eltrans = "υπερσύνδεσης"
            packHTML(5).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει τον στόχο υπερσύνδεσης για την περιοχή"
            packHTML(5).HTMLIDIOTHTES(3).syndesmos = ""
            '----------ATTRIBUTES hreflang -------'
            packHTML(5).HTMLIDIOTHTES(4).idiothta = "hreflang"
            packHTML(5).HTMLIDIOTHTES(4).Eltrans = "γλώσσα-url"
            packHTML(5).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει τη γλώσσα της διεύθυνσης URL προορισμού"
            packHTML(5).HTMLIDIOTHTES(4).syndesmos = ""
            '----------ATTRIBUTES media -------'
            packHTML(5).HTMLIDIOTHTES(5).idiothta = "media"
            packHTML(5).HTMLIDIOTHTES(5).Eltrans = "ΜΑΖΙΚΗΣ-ΕΝΗΜΕΡΩΣΗΣ"
            packHTML(5).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει για ποια μέσα/συσκευή έχει βελτιστοποιηθεί η διεύθυνση URL προορισμού"
            packHTML(5).HTMLIDIOTHTES(5).syndesmos = ""
            '----------ATTRIBUTES referrerpolicy -------'
            packHTML(5).HTMLIDIOTHTES(6).idiothta = "referrerpolicy"
            packHTML(5).HTMLIDIOTHTES(6).Eltrans = "πολιτική-παραπομπής"
            packHTML(5).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει ποιες πληροφορίες παραπομπής θα αποστέλλονται με τον σύνδεσμο"
            packHTML(5).HTMLIDIOTHTES(6).syndesmos = ""
            '----------ATTRIBUTES rel -------'
            packHTML(5).HTMLIDIOTHTES(7).idiothta = "rel"
            packHTML(5).HTMLIDIOTHTES(7).Eltrans = "σχετικά"
            packHTML(5).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει τη σχέση μεταξύ του τρέχοντος εγγράφου και της διεύθυνσης URL προορισμού"
            packHTML(5).HTMLIDIOTHTES(7).syndesmos = ""
            '----------ATTRIBUTES shape -------'
            packHTML(5).HTMLIDIOTHTES(8).idiothta = "shape"
            packHTML(5).HTMLIDIOTHTES(8).Eltrans = "σχήμα"
            packHTML(5).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει το σχήμα της περιοχής"
            packHTML(5).HTMLIDIOTHTES(8).syndesmos = ""
            '----------ATTRIBUTES target -------'
            packHTML(5).HTMLIDIOTHTES(9).idiothta = "target"
            packHTML(5).HTMLIDIOTHTES(9).Eltrans = "στόχος"
            packHTML(5).HTMLIDIOTHTES(9).Perigrafh = "Καθορίζει πού θα ανοίξει η διεύθυνση URL προορισμού"
            packHTML(5).HTMLIDIOTHTES(9).syndesmos = ""
            '----------ATTRIBUTES type -------'
            packHTML(5).HTMLIDIOTHTES(10).idiothta = "type"
            packHTML(5).HTMLIDIOTHTES(10).Eltrans = "τύπος"
            packHTML(5).HTMLIDIOTHTES(10).Perigrafh = "Καθορίζει τον τύπο μέσου της διεύθυνσης URL προορισμού"
            packHTML(5).HTMLIDIOTHTES(10).syndesmos = ""
#Region "Values"
            '----------VALUES ALT  -------'
            packHTML(5).HTMLIDIOTHTES(0).values(0).onoma = "(ΤΕΧΤ)"
            packHTML(5).HTMLIDIOTHTES(0).values(0).ellinika = "(KEIMENO)"
            packHTML(5).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει το εναλλακτικό κείμενο για την περιοχή, εάν η εικόνα δεν μπορεί να εμφανιστεί"
            '----------VALUES coords -------'
            packHTML(5).HTMLIDIOTHTES(1).values(0).onoma = "(x1,y1,x2,y2)"
            packHTML(5).HTMLIDIOTHTES(1).values(0).ellinika = "(x1,y1,x2,y2)"
            packHTML(5).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει τις συντεταγμένες της επάνω αριστερής και κάτω δεξιάς γωνίας του ορθογωνίου (σχήμα = 'rect')"
            '----------VALUES coords -------'
            packHTML(5).HTMLIDIOTHTES(1).values(1).onoma = "(x,y,radius)"
            packHTML(5).HTMLIDIOTHTES(1).values(1).ellinika = "(x,y,radius)"
            packHTML(5).HTMLIDIOTHTES(1).values(1).perigrafh = "Καθορίζει τις συντεταγμένες του κέντρου του κύκλου και της ακτίνας (σχήμα = 'κύκλος')"
            '----------VALUES coords -------'
            packHTML(5).HTMLIDIOTHTES(1).values(2).onoma = "(x1,y1,x2,y2,..,xn,yn)"
            packHTML(5).HTMLIDIOTHTES(1).values(2).ellinika = "(x1,y1,x2,y2,..,xn,yn)"
            packHTML(5).HTMLIDIOTHTES(1).values(2).perigrafh = "Καθορίζει τις συντεταγμένες των άκρων του πολυγώνου. Εάν το πρώτο και το τελευταίο ζεύγη συντεταγμένων δεν είναι ίδια, το πρόγραμμα περιήγησης θα προσθέσει το τελευταίο ζεύγος συντεταγμένων για να κλείσει το πολύγωνο (shape='poly')"
            '----------VALUES download -------'
            packHTML(5).HTMLIDIOTHTES(2).values = packHTML(2).HTMLIDIOTHTES(0).values
            '----------VALUES href -------'
            packHTML(5).HTMLIDIOTHTES(3).values = packHTML(2).HTMLIDIOTHTES(1).values
            '----------VALUES hreflang -------'
            packHTML(5).HTMLIDIOTHTES(4).values = packHTML(2).HTMLIDIOTHTES(2).values
            '----------VALUES media -------'
            packHTML(5).HTMLIDIOTHTES(5).values = packHTML(2).HTMLIDIOTHTES(3).values
            '----------VALUES referrerpolicy -------'
            packHTML(5).HTMLIDIOTHTES(6).values = packHTML(2).HTMLIDIOTHTES(4).values
            '----------VALUES rel -------'
            packHTML(5).HTMLIDIOTHTES(7).values = packHTML(2).HTMLIDIOTHTES(5).values
            '----------VALUES shape -------'
            packHTML(5).HTMLIDIOTHTES(8).values(0).onoma = "default"
            packHTML(5).HTMLIDIOTHTES(8).values(0).ellinika = "Προκαθορισμένο"
            packHTML(5).HTMLIDIOTHTES(8).values(0).perigrafh = "Καθορίζει ολόκληρη την περιοχή"
            '----------VALUES rect -------'
            packHTML(5).HTMLIDIOTHTES(8).values(1).onoma = "rect"
            packHTML(5).HTMLIDIOTHTES(8).values(1).ellinika = "ορθογώνια"
            packHTML(5).HTMLIDIOTHTES(8).values(1).perigrafh = "Ορίζει μια ορθογώνια περιοχή"
            '----------VALUES circle -------'
            packHTML(5).HTMLIDIOTHTES(8).values(2).onoma = "circle"
            packHTML(5).HTMLIDIOTHTES(8).values(2).ellinika = "κύκλος"
            packHTML(5).HTMLIDIOTHTES(8).values(2).perigrafh = "Ορίζει μια κυκλική περιοχή"
            '----------VALUES poly -------'
            packHTML(5).HTMLIDIOTHTES(8).values(3).onoma = "poly"
            packHTML(5).HTMLIDIOTHTES(8).values(3).ellinika = "πολυγωνική"
            packHTML(5).HTMLIDIOTHTES(8).values(3).perigrafh = "Ορίζει μια πολυγωνική περιοχή"
            '----------VALUES target -------'
            packHTML(5).HTMLIDIOTHTES(9).values = packHTML(2).HTMLIDIOTHTES(7).values
            '----------VALUES type -------'
            packHTML(5).HTMLIDIOTHTES(10).values = packHTML(2).HTMLIDIOTHTES(8).values
#End Region
#End Region
#Region "<article>"
            ReDim packHTML(6).HTMLIDIOTHTES(-1)

            packHTML(6).Etiketa = "<article>"
            packHTML(6).onomasia = "άρθρο"
            packHTML(6).ELtrans = "<άρθρο>"
            packHTML(6).Perigrafh = "Ορίζει ένα άρθρο"
            ' packHTML(6).Syndesmos = My.Resources.article
#End Region
#Region "<aside>"
            ReDim packHTML(7).HTMLIDIOTHTES(-1)

            packHTML(7).Etiketa = "<aside>"
            packHTML(7).onomasia = "εκτός"
            packHTML(7).ELtrans = "<εκτός>"
            packHTML(7).Perigrafh = "Ορίζει το περιεχόμενο εκτός από το περιεχόμενο της σελίδας"
            'packHTML(7).Syndesmos = My.Resources.aside
#End Region
#Region "<audio>"
            ReDim packHTML(8).HTMLIDIOTHTES(5)
            ReDim packHTML(8).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(8).HTMLIDIOTHTES(1).values(-1)
            ReDim packHTML(8).HTMLIDIOTHTES(2).values(-1)
            ReDim packHTML(8).HTMLIDIOTHTES(3).values(-1)
            ReDim packHTML(8).HTMLIDIOTHTES(4).values(3)
            ReDim packHTML(8).HTMLIDIOTHTES(5).values(0)
            ReDim packHTML(8).Events(23)
#Region "Events"
            packHTML(8).Events(0).onoma = "onabort"
            packHTML(8).Events(0).Ellinika = "ακύρωση"
            packHTML(8).Events(0).Perigrafh = "Σενάριο που θα εκτελεστεί κατά την ακύρωση"


            packHTML(8).Events(1).onoma = "oncanplay"
            packHTML(8).Events(1).Ellinika = "ξεκινήσει-αναπαραγωγή"
            packHTML(8).Events(1).Perigrafh = "Σενάριο που θα εκτελεστεί όταν ένα αρχείο είναι έτοιμο να ξεκινήσει η αναπαραγωγή (όταν έχει τοποθετηθεί αρκετά buffer για να ξεκινήσει)"

            packHTML(8).Events(2).onoma = "oncanplaythrough"
            packHTML(8).Events(2).Ellinika = "αποθήκευση-αναπαραχθεί"
            packHTML(8).Events(2).Perigrafh = "Σενάριο που θα εκτελεστεί όταν ένα αρχείο μπορεί να αναπαραχθεί μέχρι το τέλος χωρίς παύση για προσωρινή αποθήκευση"

            packHTML(8).Events(3).onoma = "oncuechange"
            packHTML(8).Events(3).Ellinika = "αλλάζει-στοιχείο"
            packHTML(8).Events(3).Perigrafh = "Σενάριο που θα εκτελεστεί όταν η υπόδειξη αλλάζει σε ένα στοιχείο <track>"

            packHTML(8).Events(4).onoma = "ondurationchange"
            packHTML(8).Events(4).Ellinika = "αλλαγή-διάρκειας"
            packHTML(8).Events(4).Perigrafh = "Σενάριο που εκτελείται όταν αλλάζει το μήκος του μέσου"


            packHTML(8).Events(5).onoma = "onemptied"
            packHTML(8).Events(5).Ellinika = "απροσδόκητη-αποσύνδεση"
            packHTML(8).Events(5).Perigrafh = "Σενάριο που θα εκτελεστεί όταν συμβαίνει κάτι κακό και το αρχείο είναι ξαφνικά μη διαθέσιμο (όπως απροσδόκητη αποσύνδεση)"

            packHTML(8).Events(6).onoma = "onemptied"
            packHTML(8).Events(6).Ellinika = "τέλος"
            packHTML(8).Events(6).Perigrafh = "Σενάριο που θα εκτελεστεί όταν τα μέσα έχουν φτάσει στο τέλος (ένα χρήσιμο συμβάν για μηνύματα όπως 'ευχαριστώ που ακούσατε')"

            packHTML(8).Events(7).onoma = "onended"
            packHTML(8).Events(7).Ellinika = "στο-τέλος"
            packHTML(8).Events(7).Perigrafh = "Σενάριο που θα εκτελεστεί όταν τα μέσα έχουν φτάσει στο τέλος (ένα χρήσιμο συμβάν για μηνύματα όπως 'ευχαριστώ που ακούσατε')"

            packHTML(8).Events(8).onoma = "onerror"
            packHTML(8).Events(8).Ellinika = "λάθος"
            packHTML(8).Events(8).Perigrafh = "Σενάριο που θα εκτελεστεί όταν παρουσιαστεί σφάλμα κατά τη φόρτωση του αρχείου"

            packHTML(8).Events(9).onoma = "onloadeddata"
            packHTML(8).Events(9).Ellinika = "εκφορτωμένα-δεδομένα"
            packHTML(8).Events(9).Perigrafh = "Σενάριο για εκτέλεση κατά τη φόρτωση δεδομένων πολυμέσων"

            packHTML(8).Events(10).onoma = "onloadedmetdada"
            packHTML(8).Events(10).Ellinika = "φορτώνονται-μεταδεδομένα"
            packHTML(8).Events(10).Perigrafh = "Σενάριο που θα εκτελείται όταν φορτώνονται μεταδεδομένα (όπως διαστάσεις και διάρκεια)."

            packHTML(8).Events(11).onoma = "onloadstart"
            packHTML(8).Events(11).Ellinika = "αρχίζει-φορτωθεί"
            packHTML(8).Events(11).Perigrafh = "Η δέσμη ενεργειών θα εκτελεστεί ακριβώς τη στιγμή που το αρχείο αρχίζει να φορτώνεται πριν φορτωθεί οτιδήποτε"

            packHTML(8).Events(12).onoma = "onpause"
            packHTML(8).Events(12).Ellinika = "παύση"
            packHTML(8).Events(12).Perigrafh = "Σενάριο που εκτελείται όταν το μέσο τίθεται σε παύση είτε από τον χρήστη είτε μέσω προγραμματισμού"

            packHTML(8).Events(13).onoma = "onplay"
            packHTML(8).Events(13).Ellinika = "έτοιμο-ξεκινήσει"
            packHTML(8).Events(13).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το μέσο είναι έτοιμο να ξεκινήσει την αναπαραγωγή"

            packHTML(8).Events(14).onoma = "onplaying"
            packHTML(8).Events(14).Ellinika = "αρχίσει-παίζει"
            packHTML(8).Events(14).Perigrafh = "Σενάριο που θα εκτελεστεί όταν τα πολυμέσα έχουν αρχίσει πραγματικά να παίζουν"

            packHTML(8).Events(15).onoma = "onprogress"
            packHTML(8).Events(15).Ellinika = "διαδικασία-λήψης"
            packHTML(8).Events(15).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το πρόγραμμα περιήγησης βρίσκεται στη διαδικασία λήψης των δεδομένων πολυμέσων"

            packHTML(8).Events(16).onoma = "onratechange"
            packHTML(8).Events(16).Ellinika = "αλλάζει-αναπαραγωγής"
            packHTML(8).Events(16).Perigrafh = "Σενάριο που θα εκτελείται κάθε φορά που αλλάζει ο ρυθμός αναπαραγωγής (όπως όταν ένας χρήστης αλλάζει σε λειτουργία αργής κίνησης ή γρήγορης προώθησης)"


            packHTML(8).Events(17).onoma = "onseeked"
            packHTML(8).Events(17).Ellinika = "αναζήτηση"
            packHTML(8).Events(17).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το χαρακτηριστικό αναζήτησης έχει οριστεί σε false υποδεικνύοντας ότι η αναζήτηση έχει τελειώσει"

            packHTML(8).Events(18).onoma = "onseeking"
            packHTML(8).Events(18).Ellinika = "αναζητώντας"
            packHTML(8).Events(18).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το χαρακτηριστικό αναζήτησης έχει οριστεί σε true, υποδεικνύοντας ότι η αναζήτηση είναι ενεργή"

            packHTML(8).Events(19).onoma = "onstalled"
            packHTML(8).Events(19).Ellinika = "εγκατεστημένο"
            packHTML(8).Events(19).Perigrafh = "Σενάριο που εκτελείται όταν το πρόγραμμα περιήγησης δεν μπορεί να ανακτήσει τα δεδομένα πολυμέσων για οποιονδήποτε λόγο"

            packHTML(8).Events(20).onoma = "onsuspend"
            packHTML(8).Events(20).Ellinika = "διακόπτεται"
            packHTML(8).Events(20).Perigrafh = "Η δέσμη ενεργειών που εκτελείται κατά την ανάκτηση των δεδομένων πολυμέσων διακόπτεται πριν φορτωθούν πλήρως για οποιονδήποτε λόγο"

            packHTML(8).Events(21).onoma = "ontimeupdate"
            packHTML(8).Events(21).Ellinika = "αλλάξει-αναπαραγωγής"
            packHTML(8).Events(21).Perigrafh = "Σενάριο που εκτελείται όταν έχει αλλάξει η θέση αναπαραγωγής (όπως όταν ο χρήστης προωθεί γρήγορα σε διαφορετικό σημείο του μέσου)"

            packHTML(8).Events(22).onoma = "onvolumechange"
            packHTML(8).Events(22).Ellinika = "εναλλαγή-έντασης"
            packHTML(8).Events(22).Perigrafh = "Σενάριο που θα εκτελείται κάθε φορά που αλλάζει ο τόμος, το οποίο (περιλαμβάνει τη ρύθμιση της έντασης σε 'σίγαση')"

            packHTML(8).Events(23).onoma = "onwaiting"
            packHTML(8).Events(23).Ellinika = "αναμένεται-συνεχιστεί"
            packHTML(8).Events(23).Perigrafh = "Σενάριο που θα εκτελείται όταν το μέσο έχει σταματήσει αλλά αναμένεται να συνεχιστεί (όπως όταν το μέσο τίθεται σε παύση για αποθήκευση περισσότερων δεδομένων)"
#End Region
            packHTML(8).Etiketa = "<audio>"
            packHTML(8).onomasia = "ήχος"
            packHTML(8).ELtrans = "<ήχος>"
            packHTML(8).Perigrafh = "Καθορίζει το ενσωματωμένο περιεχόμενο ήχου"
            ' packHTML(8).Syndesmos = My.Resources.audio
            '---------- ATTRIBUTE autoplay -------------'
            packHTML(8).HTMLIDIOTHTES(0).idiothta = "autoplay"
            packHTML(8).HTMLIDIOTHTES(0).Eltrans = "αυτoαναπαραγωγή"
            packHTML(8).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι ο ήχος θα αρχίσει να παίζει μόλις είναι έτοιμος"
            packHTML(8).HTMLIDIOTHTES(0).syndesmos = ""
            '---------- ATTRIBUTE controls -------------'
            packHTML(8).HTMLIDIOTHTES(1).idiothta = "controls"
            packHTML(8).HTMLIDIOTHTES(1).Eltrans = "ελέγχος"
            packHTML(8).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει ότι θα πρέπει να εμφανίζονται τα στοιχεία ελέγχου ήχου (όπως ένα κουμπί αναπαραγωγής/παύσης κ.λπ.)"
            packHTML(8).HTMLIDIOTHTES(1).syndesmos = ""
            '---------- ATTRIBUTE loop -------------'
            packHTML(8).HTMLIDIOTHTES(2).idiothta = "loop"
            packHTML(8).HTMLIDIOTHTES(2).Eltrans = "βρόχος"
            packHTML(8).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει ότι ο ήχος θα ξεκινά ξανά από την αρχή, κάθε φορά που τελειώνει"
            packHTML(8).HTMLIDIOTHTES(2).syndesmos = ""
            '---------- ATTRIBUTE muted -------------'
            packHTML(8).HTMLIDIOTHTES(3).idiothta = "muted"
            packHTML(8).HTMLIDIOTHTES(3).Eltrans = "σίγαση"
            packHTML(8).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει ότι η έξοδος ήχου πρέπει να είναι σε σίγαση"
            packHTML(8).HTMLIDIOTHTES(3).syndesmos = ""
            '---------- ATTRIBUTE preload -------------'
            packHTML(8).HTMLIDIOTHTES(4).idiothta = "preload"
            packHTML(8).HTMLIDIOTHTES(4).Eltrans = "προφόρτιση"
            packHTML(8).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει εάν και πώς ο συγγραφέας πιστεύει ότι ο ήχος πρέπει να φορτώνεται κατά τη φόρτωση της σελίδας"
            packHTML(8).HTMLIDIOTHTES(4).syndesmos = ""
            '---------- ATTRIBUTE src -------------'
            packHTML(8).HTMLIDIOTHTES(5).idiothta = "src"
            packHTML(8).HTMLIDIOTHTES(5).Eltrans = "διεύθυνση"
            packHTML(8).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει τη διεύθυνση URL του αρχείου ήχου"
            packHTML(8).HTMLIDIOTHTES(5).syndesmos = ""
#Region "VALUES"
            '---------- VALUES preload auto -------------'
            packHTML(8).HTMLIDIOTHTES(4).values(0).onoma = "auto"
            packHTML(8).HTMLIDIOTHTES(4).values(0).ellinika = "αυτόματα"
            packHTML(8).HTMLIDIOTHTES(4).values(0).perigrafh = "Ο συγγραφέας πιστεύει ότι το πρόγραμμα περιήγησης πρέπει να φορτώσει ολόκληρο το αρχείο ήχου όταν φορτώσει η σελίδα"
            '---------- VALUES preload metadata -------------'
            packHTML(8).HTMLIDIOTHTES(4).values(1).onoma = "metadata"
            packHTML(8).HTMLIDIOTHTES(4).values(1).ellinika = "μεταδεδομένα"
            packHTML(8).HTMLIDIOTHTES(4).values(1).perigrafh = "Ο συγγραφέας πιστεύει ότι το πρόγραμμα περιήγησης θα πρέπει να φορτώνει μόνο μεταδεδομένα κατά τη φόρτωση της σελίδας"
            '---------- VALUES preload none -------------'
            packHTML(8).HTMLIDIOTHTES(4).values(2).onoma = "none"
            packHTML(8).HTMLIDIOTHTES(4).values(2).ellinika = "κανένα"
            packHTML(8).HTMLIDIOTHTES(4).values(2).perigrafh = "Ο συγγραφέας πιστεύει ότι το πρόγραμμα περιήγησης ΔΕΝ πρέπει να φορτώνει το αρχείο ήχου όταν φορτώνεται η σελίδα"
            '---------- VALUES preload src -------------'
            packHTML(8).HTMLIDIOTHTES(5).values(0).onoma = "(URL)"
            packHTML(8).HTMLIDIOTHTES(5).values(0).ellinika = "(URL)"
            packHTML(8).HTMLIDIOTHTES(5).values(0).perigrafh = "Το URL του αρχείου ήχου. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως src='http://www.example.com/horse.ogg') Μια σχετική διεύθυνση URL 
- οδηγεί σε ένα αρχείο μέσα σε έναν ιστότοπο (όπως src='horse.ogg')"
#End Region

#End Region
#Region "<b>"
            ReDim packHTML(9).HTMLIDIOTHTES(-1)
            packHTML(9).Etiketa = "<b>"
            packHTML(9).onomasia = "Έντονο"
            packHTML(9).ELtrans = "<Έντονο>"
            packHTML(9).Perigrafh = "Ορίζει το έντονο κείμενο"
            ' packHTML(9).Syndesmos = My.Resources.b
#End Region
#Region "<base>"

            ReDim packHTML(10).HTMLIDIOTHTES(1)
            ReDim packHTML(10).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(10).HTMLIDIOTHTES(1).values(3)
            packHTML(10).Etiketa = "<base>"
            packHTML(10).onomasia = "βάση"
            packHTML(10).ELtrans = "<βάση>"
            packHTML(10).Perigrafh = "Καθορίζει τη βασική διεύθυνση URL/στόχο για όλες τις σχετικές διευθύνσεις URL σε ένα έγγραφο"
            '  packHTML(10).Syndesmos = My.Resources.base
            '---------- ATTRIBUTE href -------------'
            packHTML(10).HTMLIDIOTHTES(0).idiothta = "href"
            packHTML(10).HTMLIDIOTHTES(0).Eltrans = "διεύθυνση"
            packHTML(10).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τη βασική διεύθυνση URL για όλες τις σχετικές διευθύνσεις URL στη σελίδα"
            packHTML(10).HTMLIDIOTHTES(0).syndesmos = ""
            '---------- ATTRIBUTE target -------------'
            packHTML(10).HTMLIDIOTHTES(1).idiothta = "target"
            packHTML(10).HTMLIDIOTHTES(1).Eltrans = "στόχος"
            packHTML(10).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει τον προεπιλεγμένο στόχο για όλους τους υπερσυνδέσμους και τις φόρμες στη σελίδα"
            packHTML(10).HTMLIDIOTHTES(1).syndesmos = ""

            '---------- VALUE HREF URL -------------'
            packHTML(10).HTMLIDIOTHTES(0).values(0).onoma = "(URL)"
            packHTML(10).HTMLIDIOTHTES(0).values(0).ellinika = "(διεύθυνση)"
            packHTML(10).HTMLIDIOTHTES(0).values(0).perigrafh = "Μια απόλυτη διεύθυνση URL που λειτουργεί ως η βασική διεύθυνση URL (όπως 'http://www.example.com/')"
            '---------- VALUE target -------------'
            packHTML(10).HTMLIDIOTHTES(1).values(0) = packHTML(2).HTMLIDIOTHTES(7).values(0)
            packHTML(10).HTMLIDIOTHTES(1).values(1) = packHTML(2).HTMLIDIOTHTES(7).values(1)
            packHTML(10).HTMLIDIOTHTES(1).values(2) = packHTML(2).HTMLIDIOTHTES(7).values(2)
            packHTML(10).HTMLIDIOTHTES(1).values(3) = packHTML(2).HTMLIDIOTHTES(7).values(3)
#End Region
#Region "<bdi>"
            ReDim packHTML(11).HTMLIDIOTHTES(-1)
            packHTML(11).Etiketa = "<bdi>"
            packHTML(11).onomasia = "απομόνωση"
            packHTML(11).ELtrans = "<απομόνωση>"
            packHTML(11).Perigrafh = "Απομονώνει ένα τμήμα κειμένου που μπορεί να μορφοποιηθεί σε διαφορετική κατεύθυνση από άλλο κείμενο εκτός αυτού"
            ' packHTML(11).Syndesmos = My.Resources.bdi
#End Region
#Region "<bdo>"
            ReDim packHTML(12).HTMLIDIOTHTES(0)
            ReDim packHTML(12).HTMLIDIOTHTES(0).values(1)
            packHTML(12).Etiketa = "<bdo>"
            packHTML(12).onomasia = "τρέχουσα κατεύθυνση"
            packHTML(12).ELtrans = "<κατεύθυνση-κειμένου>"
            packHTML(12).Perigrafh = "Αντικαθιστά την τρέχουσα κατεύθυνση κειμένου"
            ' packHTML(12).Syndesmos = My.Resources.bdo

            packHTML(12).HTMLIDIOTHTES(0).idiothta = "dir"
            packHTML(12).HTMLIDIOTHTES(0).Eltrans = "κατεύθυνση"
            packHTML(12).HTMLIDIOTHTES(0).Perigrafh = "Απαιτείται. Καθορίζει την κατεύθυνση κειμένου του κειμένου μέσα στο στοιχείο <bdo>"
            packHTML(12).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(12).HTMLIDIOTHTES(0).values(0).onoma = "ltr"
            packHTML(12).HTMLIDIOTHTES(0).values(0).ellinika = "αριστερά-δεξιά"
            packHTML(12).HTMLIDIOTHTES(0).values(0).perigrafh = "αριστερά προς τα δεξιά"

            packHTML(12).HTMLIDIOTHTES(0).values(1).onoma = "rtl"
            packHTML(12).HTMLIDIOTHTES(0).values(1).ellinika = "δεξιά-αριστερά"
            packHTML(12).HTMLIDIOTHTES(0).values(1).perigrafh = "Δεξιά προς τα αριστερά"


#End Region
#Region "<blockquote>"
            ReDim packHTML(13).HTMLIDIOTHTES(0)
            ReDim packHTML(13).HTMLIDIOTHTES(0).values(0)
            packHTML(13).Etiketa = "<blockquote>"
            packHTML(13).onomasia = " εσοχή"
            packHTML(13).ELtrans = "<εσοχή>"
            packHTML(13).Perigrafh = "Ορίζει μια ενότητα που παρατίθεται από άλλη πηγή"
            ' packHTML(13).Syndesmos = My.Resources.blockquote

            packHTML(13).HTMLIDIOTHTES(0).idiothta = "cite"
            packHTML(13).HTMLIDIOTHTES(0).Eltrans = "αναφέρω"
            packHTML(13).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει την πηγή της προσφοράς"
            packHTML(13).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(13).HTMLIDIOTHTES(0).values(0).onoma = "(URL)"
            packHTML(13).HTMLIDIOTHTES(0).values(0).ellinika = "αριστερά-δεξιά"
            packHTML(13).HTMLIDIOTHTES(0).values(0).perigrafh = "Η πηγή του παραθέματος. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL 
- οδηγεί σε έναν άλλο ιστότοπο (όπως cite='http://www.example.com/page.htm') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο μέσα σε έναν ιστότοπο (όπως cite='page.htm')"
#End Region
#Region "<body>"
            ReDim packHTML(14).HTMLIDIOTHTES(-1)
            ReDim packHTML(14).Events(10)
            packHTML(14).Etiketa = "<body>"
            packHTML(14).onomasia = "σώμα"
            packHTML(14).ELtrans = "<σώμα>"
            packHTML(14).Perigrafh = "Καθορίζει το σώμα του εγγράφου"
            'packHTML(14).Syndesmos = My.Resources.body
#Region "Event"
            packHTML(14).Events(0).onoma = "onafterprint"
            packHTML(14).Events(0).Ellinika = "σε-εκτύπωση"
            packHTML(14).Events(0).Perigrafh = "Σενάριο που θα εκτελεστεί μετά την εκτύπωση του εγγράφου"

            packHTML(14).Events(1).onoma = "onbeforeprint"
            packHTML(14).Events(1).Ellinika = "πριν-εκτύπωση"
            packHTML(14).Events(1).Perigrafh = "Σενάριο που θα εκτελεστεί πριν από την εκτύπωση του εγγράφου"

            packHTML(14).Events(2).onoma = "onbeforeunload"
            packHTML(14).Events(2).Ellinika = "πριν-φόρτωση"
            packHTML(14).Events(2).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το έγγραφο πρόκειται να εκφορτωθεί"

            packHTML(14).Events(3).onoma = "onhashchange"
            packHTML(14).Events(3).Ellinika = "αλλαγές-εκτελεστεί"
            packHTML(14).Events(3).Perigrafh = "Σενάριο που θα εκτελεστεί όταν έχουν γίνει αλλαγές στο τμήμα αγκύρωσης της διεύθυνσης URL"

            packHTML(14).Events(4).onoma = "onload"
            packHTML(14).Events(4).Ellinika = "φορτίο"
            packHTML(14).Events(4).Perigrafh = "Ενεργοποιείται αφού ολοκληρωθεί η φόρτωση της σελίδας"

            packHTML(14).Events(5).onoma = "onoffline"
            packHTML(14).Events(5).Ellinika = "εκτός-σύνδεσης"
            packHTML(14).Events(5).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το πρόγραμμα περιήγησης αρχίσει να λειτουργεί εκτός σύνδεσης"

            packHTML(14).Events(6).onoma = "ononline"
            packHTML(14).Events(6).Ellinika = "με-σύνδεσης"
            packHTML(14).Events(6).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το πρόγραμμα περιήγησης αρχίσει να λειτουργεί στο διαδίκτυο"

            packHTML(14).Events(7).onoma = "onpageshow"
            packHTML(14).Events(7).Ellinika = "πλοηγείται"
            packHTML(14).Events(7).Perigrafh = "Σενάριο που εκτελείται όταν ένας χρήστης πλοηγείται σε μια σελίδα"

            packHTML(14).Events(8).onoma = "onpagehide"
            packHTML(14).Events(8).Ellinika = "απομακρύνεται-σελίδα"
            packHTML(14).Events(8).Perigrafh = "Σενάριο που εκτελείται όταν ένας χρήστης απομακρύνεται από μια σελίδα"

            packHTML(14).Events(9).onoma = "onresize"
            packHTML(14).Events(9).Ellinika = "αλλαγή-μεγέθους"
            packHTML(14).Events(9).Perigrafh = "Ενεργοποιείται όταν αλλάζει το μέγεθος του παραθύρου του προγράμματος περιήγησης"

            packHTML(14).Events(10).onoma = "onunload"
            packHTML(14).Events(10).Ellinika = "κατά-εκφόρτωση"
            packHTML(14).Events(10).Perigrafh = "Ενεργοποιείται μόλις εκφορτωθεί μια σελίδα (ή κλείσει το παράθυρο του προγράμματος περιήγησης)"
#End Region
#End Region
#Region "<br>"
            ReDim packHTML(15).HTMLIDIOTHTES(-1)
            packHTML(15).Etiketa = "<br>"
            packHTML(15).onomasia = "αλλαγή γραμμής"
            packHTML(15).ELtrans = "<Καινούργια-γραμμή>"
            packHTML(15).Perigrafh = "Ορίζει μια αλλαγή γραμμής"
            ' packHTML(15).Syndesmos = My.Resources.br
#End Region
#Region "<button>"
            ReDim packHTML(16).HTMLIDIOTHTES(10)
            ReDim packHTML(16).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(16).HTMLIDIOTHTES(1).values(-1)
            ReDim packHTML(16).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(16).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(16).HTMLIDIOTHTES(4).values(2)
            ReDim packHTML(16).HTMLIDIOTHTES(5).values(1)
            ReDim packHTML(16).HTMLIDIOTHTES(6).values(-1)
            ReDim packHTML(16).HTMLIDIOTHTES(7).values(4)
            ReDim packHTML(16).HTMLIDIOTHTES(8).values(0)
            ReDim packHTML(16).HTMLIDIOTHTES(9).values(2)
            ReDim packHTML(16).HTMLIDIOTHTES(10).values(0)
            packHTML(16).Etiketa = "<button>"
            packHTML(16).onomasia = "κουμπί"
            packHTML(16).ELtrans = "<κουμπί>"
            packHTML(16).Perigrafh = "Ορίζει ένα κουμπί με δυνατότητα κλικ"
            ' packHTML(16).Syndesmos = My.Resources.button
            '----- ATTRIBUTES autofocus -----;
            packHTML(16).HTMLIDIOTHTES(0).idiothta = "autofocus"
            packHTML(16).HTMLIDIOTHTES(0).Eltrans = "αυτόματη-εστίαση"
            packHTML(16).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι ένα κουμπί θα πρέπει να εστιάζει αυτόματα κατά τη φόρτωση της σελίδας"
            packHTML(16).HTMLIDIOTHTES(0).syndesmos = ""
            '----- ATTRIBUTES  	disabled ----'
            packHTML(16).HTMLIDIOTHTES(1).idiothta = "disabled"
            packHTML(16).HTMLIDIOTHTES(1).Eltrans = "απενεργοποιημένο"
            packHTML(16).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει ότι ένα κουμπί πρέπει να είναι απενεργοποιημένο"
            packHTML(16).HTMLIDIOTHTES(1).syndesmos = ""
            '----- ATTRIBUTES  	form ----'
            packHTML(16).HTMLIDIOTHTES(2).idiothta = "form"
            packHTML(16).HTMLIDIOTHTES(2).Eltrans = "φόρμα"
            packHTML(16).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει σε ποια μορφή ανήκει το κουμπί"
            packHTML(16).HTMLIDIOTHTES(2).syndesmos = ""
            '----- ATTRIBUTES  	formaction ----'
            packHTML(16).HTMLIDIOTHTES(3).idiothta = "formaction"
            packHTML(16).HTMLIDIOTHTES(3).Eltrans = "σχηματισμός"
            packHTML(16).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει πού θα αποστέλλονται τα δεδομένα της φόρμας όταν υποβάλλεται μια φόρμα. Μόνο για type='submit'"
            packHTML(16).HTMLIDIOTHTES(3).syndesmos = ""
            '----- ATTRIBUTES  	formenctype ----'
            packHTML(16).HTMLIDIOTHTES(4).idiothta = "formenctype"
            packHTML(16).HTMLIDIOTHTES(4).Eltrans = "μορφομορφότυπος"
            packHTML(16).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει τον τρόπο με τον οποίο θα πρέπει να κωδικοποιούνται τα δεδομένα φόρμας πριν την αποστολή τους σε διακομιστή. Μόνο για type='submit'"
            packHTML(16).HTMLIDIOTHTES(4).syndesmos = ""
            '----- ATTRIBUTES  	formmethod ----'
            packHTML(16).HTMLIDIOTHTES(5).idiothta = "formmethod"
            packHTML(16).HTMLIDIOTHTES(5).Eltrans = "μέθοδος-Αποστολής"
            packHTML(16).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει τον τρόπο αποστολής των δεδομένων φόρμας (ποια μέθοδο HTTP θα χρησιμοποιηθεί). Μόνο για type='submit'"
            packHTML(16).HTMLIDIOTHTES(5).syndesmos = ""
            '----- ATTRIBUTES  	formnovalidate ----'
            packHTML(16).HTMLIDIOTHTES(6).idiothta = "formnovalidate"
            packHTML(16).HTMLIDIOTHTES(6).Eltrans = "έντυπα-δεδομένα"
            packHTML(16).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει ότι τα έντυπα-δεδομένα δεν θα πρέπει να επικυρώνονται κατά την υποβολή. Μόνο για type='submit'"
            packHTML(16).HTMLIDIOTHTES(6).syndesmos = ""
            '----- ATTRIBUTES  	formtarget ----'
            packHTML(16).HTMLIDIOTHTES(7).idiothta = "formtarget"
            packHTML(16).HTMLIDIOTHTES(7).Eltrans = "μορφή-στόχου"
            packHTML(16).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει πού θα εμφανίζεται η απάντηση μετά την υποβολή της φόρμας. Μόνο για type='submit'"
            packHTML(16).HTMLIDIOTHTES(7).syndesmos = ""
            '----- ATTRIBUTES  	name ----'
            packHTML(16).HTMLIDIOTHTES(8).idiothta = "name"
            packHTML(16).HTMLIDIOTHTES(8).Eltrans = "όνομα"
            packHTML(16).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει ένα όνομα για το κουμπί"
            packHTML(16).HTMLIDIOTHTES(8).syndesmos = ""
            '----- ATTRIBUTES  	type ----'
            packHTML(16).HTMLIDIOTHTES(9).idiothta = "type"
            packHTML(16).HTMLIDIOTHTES(9).Eltrans = "τύπος"
            packHTML(16).HTMLIDIOTHTES(9).Perigrafh = "Καθορίζει τον τύπο του κουμπιού"
            packHTML(16).HTMLIDIOTHTES(9).syndesmos = ""
            '----- ATTRIBUTES  	value ----'
            packHTML(16).HTMLIDIOTHTES(10).idiothta = "value"
            packHTML(16).HTMLIDIOTHTES(10).Eltrans = "αξία"
            packHTML(16).HTMLIDIOTHTES(10).Perigrafh = "Καθορίζει μια αρχική τιμή για το κουμπί"
            packHTML(16).HTMLIDIOTHTES(10).syndesmos = ""


            '----- VALUE form form_id -----;
            packHTML(16).HTMLIDIOTHTES(2).values(0).onoma = "(form_id)"
            packHTML(16).HTMLIDIOTHTES(2).values(0).ellinika = "(form_id)"
            packHTML(16).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει το στοιχείο φόρμας στο οποίο ανήκει το στοιχείο <button>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο."
            '----- VALUE formaction URL -----;
            packHTML(16).HTMLIDIOTHTES(3).values(0).onoma = "(URL)"
            packHTML(16).HTMLIDIOTHTES(3).values(0).ellinika = "(URL)"
            packHTML(16).HTMLIDIOTHTES(3).values(0).perigrafh = "Καθορίζει πού θα σταλούν τα δεδομένα της φόρμας. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - η πλήρης διεύθυνση μιας σελίδας (όπως href='http://www.example.com/formresult.asp') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο στον τρέχοντα ιστότοπο (όπως href='formresult.asp')"
            '----- VALUE formenctype application/x-www-form-urlencoded -----;
            packHTML(16).HTMLIDIOTHTES(4).values(0).onoma = "application/x-www-form-urlencoded"
            packHTML(16).HTMLIDIOTHTES(4).values(0).ellinika = "application/x-www-form-urlencoded"
            packHTML(16).HTMLIDIOTHTES(4).values(0).perigrafh = "Προκαθορισμένο. Όλοι οι χαρακτήρες θα κωδικοποιηθούν πριν από την αποστολή"
            '----- VALUE formenctype multipart/form-data -----;
            packHTML(16).HTMLIDIOTHTES(4).values(1).onoma = "multipart/form-data"
            packHTML(16).HTMLIDIOTHTES(4).values(1).ellinika = "multipart/form-data"
            packHTML(16).HTMLIDIOTHTES(4).values(1).perigrafh = "Αυτή η τιμή είναι απαραίτητη εάν ο χρήστης θα ανεβάσει ένα αρχείο μέσω της φόρμαςX"
            '----- VALUE formenctype text/plain -----;
            packHTML(16).HTMLIDIOTHTES(4).values(2).onoma = "text/plain"
            packHTML(16).HTMLIDIOTHTES(4).values(2).ellinika = "text/plain"
            packHTML(16).HTMLIDIOTHTES(4).values(2).perigrafh = "Στέλνει δεδομένα χωρίς καμία απολύτως κωδικοποίηση. Δεν προτείνεται"
            '----- VALUE formmethod get -----;
            packHTML(16).HTMLIDIOTHTES(5).values(0).onoma = "get"
            packHTML(16).HTMLIDIOTHTES(5).values(0).ellinika = "παίρνω"
            packHTML(16).HTMLIDIOTHTES(5).values(0).perigrafh = "Προσθέτει τα δεδομένα της φόρμας στη διεύθυνση URL: URL?name=value&name=value"
            '----- VALUE formmethod post -----;
            packHTML(16).HTMLIDIOTHTES(5).values(1).onoma = "post"
            packHTML(16).HTMLIDIOTHTES(5).values(1).ellinika = "Θέση"
            packHTML(16).HTMLIDIOTHTES(5).values(1).perigrafh = "Στέλνει τα δεδομένα της φόρμας ως συναλλαγή μετάδοσης HTTP"
            '----- VALUE formtarget _blank -----;
            packHTML(16).HTMLIDIOTHTES(7).values(0).onoma = "_blank"
            packHTML(16).HTMLIDIOTHTES(7).values(0).ellinika = "_κενό"
            packHTML(16).HTMLIDIOTHTES(7).values(0).perigrafh = "Φορτώνει την απάντηση σε νέο παράθυρο/καρτέλα"
            '----- VALUE formtarget _self -----;
            packHTML(16).HTMLIDIOTHTES(7).values(1).onoma = "_self"
            packHTML(16).HTMLIDIOTHTES(7).values(1).ellinika = "_εαυτός"
            packHTML(16).HTMLIDIOTHTES(7).values(1).perigrafh = "Φορτώνει την απόκριση στο ίδιο πλαίσιο (αυτό είναι προεπιλεγμένο)"
            '----- VALUE formtarget _parent -----;
            packHTML(16).HTMLIDIOTHTES(7).values(2).onoma = "_parent"
            packHTML(16).HTMLIDIOTHTES(7).values(2).ellinika = "_μητρική-εταιρεία"
            packHTML(16).HTMLIDIOTHTES(7).values(2).perigrafh = "Φορτώνει την απόκριση στο γονικό πλαίσιο"
            '----- VALUE formtarget _top -----;
            packHTML(16).HTMLIDIOTHTES(7).values(3).onoma = "_top"
            packHTML(16).HTMLIDIOTHTES(7).values(3).ellinika = "_κορυφή"
            packHTML(16).HTMLIDIOTHTES(7).values(3).perigrafh = "Φορτώνει την απόκριση σε ολόκληρο το σώμα του παραθύρου"
            '----- VALUE formtarget framename -----;
            packHTML(16).HTMLIDIOTHTES(7).values(4).onoma = "(framename)"
            packHTML(16).HTMLIDIOTHTES(7).values(4).ellinika = "(όνομα-πλαισίου)"
            packHTML(16).HTMLIDIOTHTES(7).values(4).perigrafh = "Φορτώνει την απάντηση σε ένα iframe με όνομα"
            '----- VALUE formtarget name -----;
            packHTML(16).HTMLIDIOTHTES(8).values(0).onoma = "(name)"
            packHTML(16).HTMLIDIOTHTES(8).values(0).ellinika = "(όνομα)"
            packHTML(16).HTMLIDIOTHTES(8).values(0).perigrafh = "Φορτώνει την απάντηση σε ένα iframe με όνομα"
            '----- VALUE formtarget button -----;
            packHTML(16).HTMLIDIOTHTES(9).values(0).onoma = "button"
            packHTML(16).HTMLIDIOTHTES(9).values(0).ellinika = "κουμπί"
            packHTML(16).HTMLIDIOTHTES(9).values(0).perigrafh = "Το κουμπί είναι ένα κουμπί με δυνατότητα κλικ"
            '----- VALUE type submit -----;
            packHTML(16).HTMLIDIOTHTES(9).values(1).onoma = "submit"
            packHTML(16).HTMLIDIOTHTES(9).values(1).ellinika = "κουμπί"
            packHTML(16).HTMLIDIOTHTES(9).values(1).perigrafh = "Το κουμπί είναι ένα κουμπί υποβολής (υποβολή φόρμας-δεδομένα)"
            '----- VALUE type reset -----;
            packHTML(16).HTMLIDIOTHTES(9).values(2).onoma = "reset"
            packHTML(16).HTMLIDIOTHTES(9).values(2).ellinika = "επαναφορά"
            packHTML(16).HTMLIDIOTHTES(9).values(2).perigrafh = "Το κουμπί είναι ένα κουμπί επαναφοράς (επαναφέρει τη φόρμα-δεδομένα στις αρχικές τους τιμές)"
            '----- VALUE value value -----;
            packHTML(16).HTMLIDIOTHTES(10).values(0).onoma = "(value)"
            packHTML(16).HTMLIDIOTHTES(10).values(0).ellinika = "(τιμή)"
            packHTML(16).HTMLIDIOTHTES(10).values(0).perigrafh = "Η αρχική τιμή του κουμπιού"

#End Region
#Region "<canvas>"
            ReDim packHTML(17).HTMLIDIOTHTES(1)
            ReDim packHTML(17).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(17).HTMLIDIOTHTES(1).values(0)
            packHTML(17).Etiketa = "<canvas>"
            packHTML(17).onomasia = "καμβάς"
            packHTML(17).ELtrans = "<καμβάς>"
            packHTML(17).Perigrafh = "Χρησιμοποιείται για τη σχεδίαση γραφικών, εν κινήσει, μέσω scripting (συνήθως JavaScript)"
            ' packHTML(17).Syndesmos = My.Resources.canvas

            packHTML(17).HTMLIDIOTHTES(0).idiothta = "height"
            packHTML(17).HTMLIDIOTHTES(0).Eltrans = "ύψος"
            packHTML(17).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει το ύψος του καμβά. Η προεπιλεγμένη τιμή είναι 150"
            packHTML(17).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(17).HTMLIDIOTHTES(1).idiothta = "width"
            packHTML(17).HTMLIDIOTHTES(1).Eltrans = "πλάτος"
            packHTML(17).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει το ύψος του καμβά. Η προεπιλεγμένη τιμή είναι 150"
            packHTML(17).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(17).HTMLIDIOTHTES(0).values(0).onoma = "(pixels)"
            packHTML(17).HTMLIDIOTHTES(0).values(0).ellinika = "(pixels)"
            packHTML(17).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει το ύψος του καμβά, σε pixel (π.χ. '100'). Η προεπιλεγμένη τιμή είναι 150"

            packHTML(17).HTMLIDIOTHTES(1).values(0).onoma = "(pixels)"
            packHTML(17).HTMLIDIOTHTES(1).values(0).ellinika = "(pixels)"
            packHTML(17).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει το πλάτος του καμβά, σε pixel (π.χ. '100'). Η προεπιλεγμένη τιμή είναι 300"

#End Region
#Region "<caption>"
            ReDim packHTML(18).HTMLIDIOTHTES(-1)
            packHTML(18).Etiketa = "<caption>"
            packHTML(18).onomasia = "λεζάντα"
            packHTML(18).ELtrans = "<λεζάντα>"
            packHTML(18).Perigrafh = "Ορίζει μια λεζάντα πίνακα"
            ' packHTML(18).Syndesmos = My.Resources.caption
#End Region
#Region "<cite>"
            ReDim packHTML(19).HTMLIDIOTHTES(-1)
            packHTML(19).Etiketa = "<cite>"
            packHTML(19).onomasia = "αναφορά"
            packHTML(19).ELtrans = "<αναφορά>"
            packHTML(19).Perigrafh = "Καθορίζει τον τίτλο ενός έργου"
            ' packHTML(19).Syndesmos = My.Resources.cite
#End Region
#Region "<code>"
            ReDim packHTML(20).HTMLIDIOTHTES(-1)
            packHTML(20).Etiketa = "<code>"
            packHTML(20).onomasia = "κώδικας"
            packHTML(20).ELtrans = "<κώδικας>"
            packHTML(20).Perigrafh = "Ορίζει ένα κομμάτι κώδικα υπολογιστή"
            ' packHTML(20).Syndesmos = My.Resources.code
#End Region
#Region "<col>"
            ReDim packHTML(21).HTMLIDIOTHTES(0)
            ReDim packHTML(21).HTMLIDIOTHTES(0).values(0)
            packHTML(21).Etiketa = "<col>"
            packHTML(21).onomasia = "στήλη"
            packHTML(21).ELtrans = "<στήλη>"
            packHTML(21).Perigrafh = "Καθορίζει τις ιδιότητες στήλης για κάθε στήλη μέσα σε ένα στοιχείο <colgroup>"
            ' packHTML(21).Syndesmos = My.Resources.col

            packHTML(21).HTMLIDIOTHTES(0).idiothta = "span"
            packHTML(21).HTMLIDIOTHTES(0).Eltrans = "σπιθαμή"
            packHTML(21).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τον αριθμό των στηλών που πρέπει να εκτείνεται ένα στοιχείο <col>"
            packHTML(21).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(21).HTMLIDIOTHTES(0).values(0).onoma = "(number)"
            packHTML(21).HTMLIDIOTHTES(0).values(0).ellinika = "(αριθμός)"
            packHTML(21).HTMLIDIOTHTES(0).values(0).perigrafh = "Ορίζει τον αριθμό των στηλών που πρέπει να εκτείνεται ένα στοιχείο <col>"

#End Region
#Region "<colgroup>"
            ReDim packHTML(22).HTMLIDIOTHTES(0)
            ReDim packHTML(22).HTMLIDIOTHTES(0).values(0)
            packHTML(22).Etiketa = "<colgroup>"
            packHTML(22).onomasia = "ομάδα-στηλών"
            packHTML(22).ELtrans = "<ομάδα-στηλών>"
            packHTML(22).Perigrafh = "Καθορίζει τις ιδιότητες στήλης για κάθε στήλη μέσα σε ένα στοιχείο <colgroup>"
            packHTML(22).Syndesmos = ""

            packHTML(22).HTMLIDIOTHTES(0).idiothta = "span"
            packHTML(22).HTMLIDIOTHTES(0).Eltrans = "σπιθαμή"
            packHTML(22).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τον αριθμό των στηλών που πρέπει να εκτείνεται σε μια ομάδα στηλών"
            packHTML(22).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(22).HTMLIDIOTHTES(0).values(0).onoma = "(number)"
            packHTML(22).HTMLIDIOTHTES(0).values(0).ellinika = "(αριθμός)"
            packHTML(22).HTMLIDIOTHTES(0).values(0).perigrafh = "Ορίζει τον αριθμό των στηλών που πρέπει να εκτείνεται σε μια ομάδα στηλών"

#End Region
#Region "<data>"
            ReDim packHTML(23).HTMLIDIOTHTES(0)
            ReDim packHTML(23).HTMLIDIOTHTES(0).values(1)
            packHTML(23).Etiketa = "<data>"
            packHTML(23).onomasia = "δεδομένα"
            packHTML(23).ELtrans = "<δεδομένα>"
            packHTML(23).Perigrafh = "Η ετικέτα <data> χρησιμοποιείται για την προσθήκη μιας μηχανής αναγνώσιμης μετάφρασης ενός δεδομένου περιεχομένου"
            packHTML(23).Syndesmos = ""

            packHTML(23).HTMLIDIOTHTES(0).idiothta = "value"
            packHTML(23).HTMLIDIOTHTES(0).Eltrans = "τιμή"
            packHTML(23).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει την αναγνώσιμη από μηχανή μετάφραση του περιεχομένου του στοιχείου"
            packHTML(23).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(23).HTMLIDIOTHTES(0).values(0).onoma = "machine-readable"
            packHTML(23).HTMLIDIOTHTES(0).values(0).ellinika = "αναγνώσιμο-μηχανή"
            packHTML(23).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει την αναγνώσιμη από μηχανή μετάφραση του περιεχομένου του στοιχείου"

            packHTML(23).HTMLIDIOTHTES(0).values(1).onoma = "format"
            packHTML(23).HTMLIDIOTHTES(0).values(1).ellinika = "διάταξις"
            packHTML(23).HTMLIDIOTHTES(0).values(1).perigrafh = "Καθορίζει την αναγνώσιμη από μηχανή μετάφραση του περιεχομένου του στοιχείου"
#End Region
#Region "<datalist>"
            ReDim packHTML(24).HTMLIDIOTHTES(-1)
            packHTML(24).Etiketa = "<datalist>"
            packHTML(24).onomasia = "λίστα δεδομένων"
            packHTML(24).ELtrans = "<λίστα-δεδομένων>"
            packHTML(24).Perigrafh = "Η ετικέτα <datalist> καθορίζει μια λίστα με προκαθορισμένες επιλογές για ένα στοιχείο <input>."
            packHTML(24).Syndesmos = ""
#End Region
#Region "<dd>"
            ReDim packHTML(25).HTMLIDIOTHTES(-1)
            packHTML(25).Etiketa = "<dd>"
            packHTML(25).onomasia = "λίστα περιγραφής"
            packHTML(25).ELtrans = "<λίστα-περιγραφής>"
            packHTML(25).Perigrafh = "Η ετικέτα <dd> χρησιμοποιείται για να περιγράψει έναν όρο/όνομα σε μια λίστα περιγραφής."
            packHTML(25).Syndesmos = ""
#End Region
#Region "<del>"
            ReDim packHTML(26).HTMLIDIOTHTES(1)
            ReDim packHTML(26).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(26).HTMLIDIOTHTES(1).values(0)
            packHTML(26).Etiketa = "<del>"
            packHTML(26).onomasia = "διαγραφεί"
            packHTML(26).ELtrans = "<διαγραφή>"
            packHTML(26).Perigrafh = "Η ετικέτα <del> ορίζει κείμενο που έχει διαγραφεί από ένα έγγραφο. Τα προγράμματα περιήγησης συνήθως χτυπούν μια γραμμή μέσω του διαγραμμένου κειμένου"
            packHTML(26).Syndesmos = ""

            packHTML(26).HTMLIDIOTHTES(0).idiothta = "cite"
            packHTML(26).HTMLIDIOTHTES(0).Eltrans = "αναφορά"
            packHTML(26).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει μια διεύθυνση URL σε ένα έγγραφο που εξηγεί τον λόγο για τον οποίο το κείμενο διαγράφηκε/αλλάχθηκε"
            packHTML(26).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(26).HTMLIDIOTHTES(1).idiothta = "datetime"
            packHTML(26).HTMLIDIOTHTES(1).Eltrans = "ημερομηνία-ώρα"
            packHTML(26).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει την ημερομηνία και την ώρα κατά την οποία το κείμενο διαγράφηκε/αλλάχθηκε"
            packHTML(26).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(26).HTMLIDIOTHTES(0).values(0).onoma = "(URL)"
            packHTML(26).HTMLIDIOTHTES(0).values(0).ellinika = "(URL)"
            packHTML(26).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει τη διεύθυνση στο έγγραφο που εξηγεί γιατί το κείμενο διαγράφηκε. Πιθανές τιμές: Ένα απόλυτο URL - οδηγεί σε έναν άλλο ιστότοπο (όπως cite='http://www.example.com/page.htm') Μια σχετική διεύθυνση URL - οδηγεί σε μια σελίδα σε έναν ιστότοπο (όπως cite='page.htm')"

            packHTML(26).HTMLIDIOTHTES(1).values(0).onoma = "(YYYY-MM-DDThh:mm:ssTZD)"
            packHTML(26).HTMLIDIOTHTES(1).values(0).ellinika = "(YYYY-MM-DDThh:mm:ssTZD)"
            packHTML(26).HTMLIDIOTHTES(1).values(0).perigrafh = "Η ημερομηνία και η ώρα διαγραφής του κειμένου. Επεξήγηση των εξαρτημάτων: ΕΕΕΕ - έτος (π.χ. 2012) ΜΜ - μήνας (π.χ. 01 Ιανουαρίου) ΗΗ - ημέρα του μήνα (π.χ. 08) T ή ένα διάστημα - ένα διαχωριστικό (απαιτείται εάν έχει επίσης καθοριστεί ο χρόνος) ωω - ώρα (π.χ. 22 για τις 22:00) mm - λεπτά (π.χ. 55) ss - δευτερόλεπτα (π.χ. 03) TZD - Προσδιορισμός ζώνης ώρας (το Z υποδηλώνει τα Ζουλού, γνωστό και ως Μέση ώρα Γκρίνουιτς)"


#End Region
#Region "<details>"
            ReDim packHTML(27).HTMLIDIOTHTES(0)
            ReDim packHTML(27).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(27).Events(0)
            packHTML(27).Etiketa = "<details>"
            packHTML(27).onomasia = "Λεπτομέριες"
            packHTML(27).ELtrans = "<Λεπτομέριες>"
            packHTML(27).Perigrafh = "Η ετικέτα <details> καθορίζει πρόσθετες λεπτομέρειες που ο χρήστης μπορεί να ανοίγει και να κλείνει κατά παραγγελία."
            packHTML(27).Syndesmos = ""

            packHTML(27).HTMLIDIOTHTES(0).idiothta = "open"
            packHTML(27).HTMLIDIOTHTES(0).Eltrans = "Άνοιξε"
            packHTML(27).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι οι λεπτομέρειες πρέπει να είναι ορατές (ανοιχτές) στον χρήστη"
            packHTML(27).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(27).Events(0).onoma = "ontoggle"
            packHTML(27).Events(0).Ellinika = "εναλλάσσω"
            packHTML(27).Events(0).Perigrafh = "Ενεργοποιείται όταν ο χρήστης ανοίγει ή κλείνει το στοιχείο <details>"

#End Region
#Region "<dfn>"
            ReDim packHTML(28).HTMLIDIOTHTES(-1)
            packHTML(28).Etiketa = "<dfn>"
            packHTML(28).onomasia = "στοιχείο ορισμού"
            packHTML(28).ELtrans = "<στοιχείο-ορισμού>"
            packHTML(28).Perigrafh = "Η ετικέτα <dfn> αντιπροσωπεύει το 'στοιχείο ορισμού' και καθορίζει έναν όρο που πρόκειται να οριστεί μέσα στο περιεχόμενο."
            packHTML(28).Syndesmos = ""
#End Region
#Region "<dialog>"
            ReDim packHTML(29).HTMLIDIOTHTES(0)
            ReDim packHTML(29).HTMLIDIOTHTES(0).values(-1)
            packHTML(29).Etiketa = "<dialog>"
            packHTML(29).onomasia = "διαλόγου"
            packHTML(29).ELtrans = "<διαλόγου>"
            packHTML(29).Perigrafh = "Η ετικέτα <dialog> ορίζει ένα πλαίσιο διαλόγου ή ένα υποπαράθυρο."
            packHTML(29).Syndesmos = ""

            packHTML(29).HTMLIDIOTHTES(0).idiothta = "open"
            packHTML(29).HTMLIDIOTHTES(0).Eltrans = "Άνοιξε"
            packHTML(29).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι το στοιχείο διαλόγου είναι ενεργό και ότι ο χρήστης μπορεί να αλληλεπιδράσει μαζί του"
            packHTML(29).HTMLIDIOTHTES(0).syndesmos = ""

#End Region
#Region "<div>"
            ReDim packHTML(30).HTMLIDIOTHTES(-1)
            packHTML(30).Etiketa = "<div>"
            packHTML(30).onomasia = "ενότητα"
            packHTML(30).ELtrans = "<ενότητα>"
            packHTML(30).Perigrafh = "Η ετικέτα <div> ορίζει μια διαίρεση ή μια ενότητα σε ένα έγγραφο HTML."
            packHTML(30).Syndesmos = ""
#End Region
#Region "<dl>"
            ReDim packHTML(31).HTMLIDIOTHTES(-1)
            packHTML(31).Etiketa = "<dl>"
            packHTML(31).onomasia = "περιγραφής"
            packHTML(31).ELtrans = "<περιγραφής>"
            packHTML(31).Perigrafh = "Η ετικέτα <dl> ορίζει μια λίστα περιγραφής"
            packHTML(31).Syndesmos = ""
#End Region
#Region "<dt>"
            ReDim packHTML(32).HTMLIDIOTHTES(-1)
            packHTML(32).Etiketa = "<dt>"
            packHTML(32).onomasia = "λίστα περιγραφής"
            packHTML(32).ELtrans = "<λίστα-περιγραφής>"
            packHTML(32).Perigrafh = "Η ετικέτα <dt> ορίζει έναν όρο/όνομα σε μια λίστα περιγραφής."
            packHTML(32).Syndesmos = ""
#End Region
#Region "<em>"
            ReDim packHTML(33).HTMLIDIOTHTES(-1)
            packHTML(33).Etiketa = "<em>"
            packHTML(33).onomasia = "έμφαση"
            packHTML(33).ELtrans = "<έμφαση>"
            packHTML(33).Perigrafh = "Η ετικέτα <em> χρησιμοποιείται για να ορίσει κείμενο με έμφαση. Το περιεχόμενο στο εσωτερικό εμφανίζεται συνήθως με πλάγια γραφή"
            packHTML(33).Syndesmos = ""
#End Region
#Region "<embed>"
            ReDim packHTML(34).HTMLIDIOTHTES(3)
            ReDim packHTML(34).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(34).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(34).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(34).HTMLIDIOTHTES(3).values(0)
            packHTML(34).Etiketa = "<embed>"
            packHTML(34).onomasia = "ενθέτω"
            packHTML(34).ELtrans = "<ενθέτω>"
            packHTML(34).Perigrafh = "Η ετικέτα <embed> ορίζει ένα κοντέινερ για έναν εξωτερικό πόρο, όπως μια ιστοσελίδα, μια εικόνα, μια συσκευή αναπαραγωγής πολυμέσων ή μια εφαρμογή προσθήκης."
            packHTML(34).Syndesmos = ""
            '---ATTRIBUTES height ---'
            packHTML(34).HTMLIDIOTHTES(0).idiothta = "height"
            packHTML(34).HTMLIDIOTHTES(0).Eltrans = "ύψος"
            packHTML(34).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει το ύψος του ενσωματωμένου περιεχομένου"
            packHTML(34).HTMLIDIOTHTES(0).syndesmos = ""
            '---ATTRIBUTES src ---'
            packHTML(34).HTMLIDIOTHTES(1).idiothta = "src"
            packHTML(34).HTMLIDIOTHTES(1).Eltrans = "διεύθυνση"
            packHTML(34).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει τη διεύθυνση του εξωτερικού αρχείου προς ενσωμάτωση"
            packHTML(34).HTMLIDIOTHTES(1).syndesmos = ""
            '---ATTRIBUTES type ---'
            packHTML(34).HTMLIDIOTHTES(2).idiothta = "type"
            packHTML(34).HTMLIDIOTHTES(2).Eltrans = "τύπος"
            packHTML(34).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει τον τύπο πολυμέσων του ενσωματωμένου περιεχομένου"
            packHTML(34).HTMLIDIOTHTES(2).syndesmos = ""
            '---ATTRIBUTES width---'
            packHTML(34).HTMLIDIOTHTES(3).idiothta = "width"
            packHTML(34).HTMLIDIOTHTES(3).Eltrans = "πλάτος"
            packHTML(34).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει το πλάτος του ενσωματωμένου περιεχομένου"
            packHTML(34).HTMLIDIOTHTES(3).syndesmos = ""


            packHTML(34).HTMLIDIOTHTES(0).values(0).onoma = "(pixels)"
            packHTML(34).HTMLIDIOTHTES(0).values(0).ellinika = "(ύψος)"
            packHTML(34).HTMLIDIOTHTES(0).values(0).perigrafh = "Το ύψος του ενσωματωμένου περιεχομένου, σε pixel (δηλαδή ύψος = '100')"

            packHTML(34).HTMLIDIOTHTES(1).values(0).onoma = "(URL)"
            packHTML(34).HTMLIDIOTHTES(1).values(0).ellinika = "(URL)"
            packHTML(34).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει τη διεύθυνση του εξωτερικού αρχείου προς ενσωμάτωση. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως href='http://www.example.com/hello.swf') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο σε έναν ιστότοπο (όπως href='hello.swf')"

            packHTML(34).HTMLIDIOTHTES(2).values(0).onoma = "(media_type)"
            packHTML(34).HTMLIDIOTHTES(2).values(0).ellinika = "(Τύπος πολυμέσων)"
            packHTML(34).HTMLIDIOTHTES(2).values(0).perigrafh = "Ο τύπος μέσων Διαδικτύου του ενσωματωμένου περιεχομένου. Ανατρέξτε στο IANA Media Types για μια πλήρη λίστα με τυπικούς τύπους μέσων."

            packHTML(34).HTMLIDIOTHTES(3).values(0).onoma = "(pixels)"
            packHTML(34).HTMLIDIOTHTES(3).values(0).ellinika = "(πλάτος)"
            packHTML(34).HTMLIDIOTHTES(3).values(0).perigrafh = "Το πλάτος του ενσωματωμένου περιεχομένου, σε pixel (δηλαδή πλάτος = '100')"
#End Region
#Region "<fieldset>"

            ReDim packHTML(35).HTMLIDIOTHTES(2)
            ReDim packHTML(35).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(35).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(35).HTMLIDIOTHTES(2).values(0)
            packHTML(35).Etiketa = "<fieldset>"
            packHTML(35).onomasia = "σύνολο πεδίων"
            packHTML(35).ELtrans = "<σύνολο-πεδίων>"
            packHTML(35).Perigrafh = "Η ετικέτα <fieldset> χρησιμοποιείται για την ομαδοποίηση σχετικών στοιχείων σε μια φόρμα"
            packHTML(35).Syndesmos = ""

            packHTML(35).HTMLIDIOTHTES(0).idiothta = "disabled"
            packHTML(35).HTMLIDIOTHTES(0).Eltrans = "απενεργοποιημένη"
            packHTML(35).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι μια ομάδα σχετικών στοιχείων φόρμας θα πρέπει να είναι απενεργοποιημένη"
            packHTML(35).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(35).HTMLIDIOTHTES(1).idiothta = "form"
            packHTML(35).HTMLIDIOTHTES(1).Eltrans = "μορφή"
            packHTML(35).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει σε ποια μορφή ανήκει το σύνολο πεδίων"
            packHTML(35).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(35).HTMLIDIOTHTES(2).idiothta = "name"
            packHTML(35).HTMLIDIOTHTES(2).Eltrans = "όνομα"
            packHTML(35).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει ένα όνομα για το σύνολο πεδίων"
            packHTML(35).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(35).HTMLIDIOTHTES(2).values(0).onoma = "(form_id)"
            packHTML(35).HTMLIDIOTHTES(2).values(0).ellinika = "(form_id)"
            packHTML(35).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει το στοιχείο φόρμας στο οποίο ανήκει το στοιχείο <fieldset>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο."

            packHTML(35).HTMLIDIOTHTES(2).values(0).onoma = "(name)"
            packHTML(35).HTMLIDIOTHTES(2).values(0).ellinika = "(όνομα)"
            packHTML(35).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει το όνομα του συνόλου πεδίων"

#End Region
#Region "<figcaption>"
            ReDim packHTML(36).HTMLIDIOTHTES(-1)
            packHTML(36).Etiketa = "<figcaption>"
            packHTML(36).onomasia = "λεζάντα"
            packHTML(36).ELtrans = "<λεζάντα>"
            packHTML(36).Perigrafh = "Η ετικέτα <figcaption> ορίζει μια λεζάντα για ένα στοιχείο <figure>."
            packHTML(36).Syndesmos = ""
#End Region
#Region "<figure>"
            ReDim packHTML(37).HTMLIDIOTHTES(-1)
            packHTML(37).Etiketa = "<figure>"
            packHTML(37).onomasia = "περιεχόμενο"
            packHTML(37).ELtrans = "<περιεχόμενο>"
            packHTML(37).Perigrafh = "Η ετικέτα <figure> καθορίζει αυτόνομο περιεχόμενο, όπως εικόνες, διαγράμματα, φωτογραφίες, καταχωρίσεις κωδικών κ.λπ."
            packHTML(37).Syndesmos = ""
#End Region
#Region "<footer>"
            ReDim packHTML(38).HTMLIDIOTHTES(-1)
            packHTML(38).Etiketa = "<footer>"
            packHTML(38).onomasia = "υποσέλιδο"
            packHTML(38).ELtrans = "<υποσέλιδο>"
            packHTML(38).Perigrafh = "Η ετικέτα <footer> ορίζει ένα υποσέλιδο για ένα έγγραφο ή ενότητα."
            packHTML(38).Syndesmos = ""
#End Region
#Region "<form>"
            ReDim packHTML(39).HTMLIDIOTHTES(8)
            ReDim packHTML(39).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(39).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(39).HTMLIDIOTHTES(2).values(1)
            ReDim packHTML(39).HTMLIDIOTHTES(3).values(2)
            ReDim packHTML(39).HTMLIDIOTHTES(4).values(1)
            ReDim packHTML(39).HTMLIDIOTHTES(5).values(0)
            ReDim packHTML(39).HTMLIDIOTHTES(6).values(-1)
            ReDim packHTML(39).HTMLIDIOTHTES(7).values(9)
            ReDim packHTML(39).HTMLIDIOTHTES(8).values(3)
            ReDim packHTML(39).Events(1)
            packHTML(39).Etiketa = "<form>"
            packHTML(39).onomasia = "Φόρμα"
            packHTML(39).ELtrans = "<Φόρμα>"
            packHTML(39).Perigrafh = "Η ετικέτα <form> χρησιμοποιείται για τη δημιουργία μιας φόρμας HTML για εισαγωγή χρήστη."
            packHTML(39).Syndesmos = ""

#Region "Event"
            packHTML(39).Events(0).onoma = "onreset"
            packHTML(39).Events(0).Ellinika = "Επαναφορά"
            packHTML(39).Events(0).Perigrafh = "Ενεργοποιείται όταν κάνετε κλικ στο κουμπί Επαναφορά σε μια φόρμα"

            packHTML(39).Events(1).onoma = "onsubmit"
            packHTML(39).Events(1).Ellinika = "υποβολή"
            packHTML(39).Events(1).Perigrafh = "Πυρκαγιά όταν υποβάλλεται μια φόρμα"
#End Region
#Region "ATTRIBUTES"
            '---- ATTRIBUTES accept-charset ----'
            packHTML(39).HTMLIDIOTHTES(0).idiothta = "accept-charset"
            packHTML(39).HTMLIDIOTHTES(0).Eltrans = "αποδοχή-χαρακτήρων"
            packHTML(39).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τις κωδικοποιήσεις χαρακτήρων που πρόκειται να χρησιμοποιηθούν για την υποβολή της φόρμας"
            packHTML(39).HTMLIDIOTHTES(0).syndesmos = ""
            '---- ATTRIBUTES action----'
            packHTML(39).HTMLIDIOTHTES(1).idiothta = "action"
            packHTML(39).HTMLIDIOTHTES(1).Eltrans = "δράση"
            packHTML(39).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει πού θα αποστέλλονται τα δεδομένα της φόρμας όταν υποβάλλεται μια φόρμα"
            packHTML(39).HTMLIDIOTHTES(1).syndesmos = ""
            '---- ATTRIBUTES autocomplete----'
            packHTML(39).HTMLIDIOTHTES(2).idiothta = "autocomplete"
            packHTML(39).HTMLIDIOTHTES(2).Eltrans = "αυτόματη-συμπλήρωση"
            packHTML(39).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει εάν μια φόρμα θα πρέπει να έχει ενεργοποίηση ή απενεργοποίηση αυτόματης συμπλήρωσης"
            packHTML(39).HTMLIDIOTHTES(2).syndesmos = ""
            '---- ATTRIBUTES enctype----'
            packHTML(39).HTMLIDIOTHTES(3).idiothta = "enctype"
            packHTML(39).HTMLIDIOTHTES(3).Eltrans = "εγτύπος"
            packHTML(39).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει τον τρόπο με τον οποίο θα πρέπει να κωδικοποιούνται τα δεδομένα φόρμας κατά την υποβολή τους στον διακομιστή (μόνο για τη μέθοδο = 'post')"
            packHTML(39).HTMLIDIOTHTES(3).syndesmos = ""
            '---- ATTRIBUTES method----'
            packHTML(39).HTMLIDIOTHTES(4).idiothta = "method"
            packHTML(39).HTMLIDIOTHTES(4).Eltrans = "μέθοδος"
            packHTML(39).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει τη μέθοδο HTTP που θα χρησιμοποιηθεί κατά την αποστολή δεδομένων φόρμας"
            packHTML(39).HTMLIDIOTHTES(4).syndesmos = ""
            '---- ATTRIBUTES name ----'
            packHTML(39).HTMLIDIOTHTES(5).idiothta = "name"
            packHTML(39).HTMLIDIOTHTES(5).Eltrans = "όνομα"
            packHTML(39).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει το όνομα μιας φόρμας"
            packHTML(39).HTMLIDIOTHTES(5).syndesmos = ""
            '---- ATTRIBUTES novalidate----'
            packHTML(39).HTMLIDIOTHTES(6).idiothta = "novalidate"
            packHTML(39).HTMLIDIOTHTES(6).Eltrans = "ακυρώνω"
            packHTML(39).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει ότι η φόρμα δεν πρέπει να επικυρώνεται κατά την υποβολή"
            packHTML(39).HTMLIDIOTHTES(6).syndesmos = ""
            '---- ATTRIBUTES rel----'
            packHTML(39).HTMLIDIOTHTES(7).idiothta = "rel"
            packHTML(39).HTMLIDIOTHTES(7).Eltrans = "σχέση"
            packHTML(39).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει τη σχέση μεταξύ ενός συνδεδεμένου πόρου και του τρέχοντος εγγράφου"
            packHTML(39).HTMLIDIOTHTES(7).syndesmos = ""
            '---- ATTRIBUTES target----'
            packHTML(39).HTMLIDIOTHTES(8).idiothta = "target"
            packHTML(39).HTMLIDIOTHTES(8).Eltrans = "στόχος"
            packHTML(39).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει πού θα εμφανίζεται η απάντηση που λαμβάνεται μετά την υποβολή της φόρμας"
            packHTML(39).HTMLIDIOTHTES(8).syndesmos = ""
#End Region
#Region "VALUES"
            '--------- VALUES accept-charset character_set-------'
            packHTML(39).HTMLIDIOTHTES(0).values(0).onoma = "(character_set)"
            packHTML(39).HTMLIDIOTHTES(0).values(0).ellinika = "(character_set)"
            packHTML(39).HTMLIDIOTHTES(8).values(0).perigrafh = "Μια λίστα διαχωρισμένη σε διάστημα μιας ή περισσότερων κωδικοποιήσεων χαρακτήρων που πρόκειται να χρησιμοποιηθούν για την υποβολή της φόρμας. Κοινές αξίες: UTF-8 - Κωδικοποίηση χαρακτήρων για Unicode ISO-8859-1 - Κωδικοποίηση χαρακτήρων για το λατινικό αλφάβητο"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(1).values(0).onoma = "(URL)"
            packHTML(39).HTMLIDIOTHTES(1).values(0).ellinika = "(URL)"
            packHTML(39).HTMLIDIOTHTES(1).values(0).perigrafh = "Πού να στείλετε τη φόρμα-δεδομένα κατά την υποβολή της φόρμας. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως action='http://www.example.com/example.htm') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο σε έναν ιστότοπο (όπως action='example.htm')"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(2).values(0).onoma = "on"
            packHTML(39).HTMLIDIOTHTES(2).values(0).ellinika = "ενεργοποιήση"
            packHTML(39).HTMLIDIOTHTES(2).values(0).perigrafh = "Προκαθορισμένο. Το πρόγραμμα περιήγησης θα συμπληρώσει αυτόματα τις τιμές με βάση τις τιμές που ο χρήστης έχει εισαγάγει προηγουμένως"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(2).values(1).onoma = "off"
            packHTML(39).HTMLIDIOTHTES(2).values(1).ellinika = "απανεργοποιήση"
            packHTML(39).HTMLIDIOTHTES(2).values(1).perigrafh = "Ο χρήστης πρέπει να εισάγει μια τιμή σε κάθε πεδίο για κάθε χρήση. Το πρόγραμμα περιήγησης δεν ολοκληρώνει αυτόματα τις καταχωρήσεις"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(3).values(0).onoma = "application/x-www-form-urlencoded"
            packHTML(39).HTMLIDIOTHTES(3).values(0).ellinika = "application/x-www-form-urlencoded"
            packHTML(39).HTMLIDIOTHTES(3).values(0).perigrafh = "Προκαθορισμένο. Όλοι οι χαρακτήρες κωδικοποιούνται πριν από την αποστολή (τα κενά μετατρέπονται σε σύμβολα '+' και οι ειδικοί χαρακτήρες μετατρέπονται σε τιμές ASCII HEX)"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(3).values(1).onoma = "multipart/form-data"
            packHTML(39).HTMLIDIOTHTES(3).values(1).ellinika = "multipart/form-data"
            packHTML(39).HTMLIDIOTHTES(3).values(1).perigrafh = "Αυτή η τιμή είναι απαραίτητη εάν ο χρήστης θα ανεβάσει ένα αρχείο μέσω της φόρμας"
            '--------- VALUES -------
            packHTML(39).HTMLIDIOTHTES(3).values(2).onoma = "text/plain"
            packHTML(39).HTMLIDIOTHTES(3).values(2).ellinika = "text/plain"
            packHTML(39).HTMLIDIOTHTES(3).values(2).perigrafh = "Στέλνει δεδομένα χωρίς καμία απολύτως κωδικοποίηση. Δεν προτείνεται"
            '--------- VALUES -------
            packHTML(39).HTMLIDIOTHTES(4).values(0).onoma = "get"
            packHTML(39).HTMLIDIOTHTES(4).values(0).ellinika = "παίρνω"
            packHTML(39).HTMLIDIOTHTES(4).values(0).perigrafh = "Προκαθορισμένο. Προσθέτει τα δεδομένα φόρμας στη διεύθυνση URL σε ζεύγη ονόματος/τιμής: URL?name=value&name=value"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(4).values(1).onoma = "post"
            packHTML(39).HTMLIDIOTHTES(4).values(1).ellinika = "Θέση"
            packHTML(39).HTMLIDIOTHTES(4).values(1).perigrafh = "Στέλνει τα δεδομένα της φόρμας ως συναλλαγή μετάδοσης HTTP"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(5).values(0).onoma = "(text)"
            packHTML(39).HTMLIDIOTHTES(5).values(0).ellinika = "(κείμενο)"
            packHTML(39).HTMLIDIOTHTES(5).values(0).perigrafh = "Καθορίζει το όνομα της φόρμας"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(0).onoma = "external"
            packHTML(39).HTMLIDIOTHTES(7).values(0).ellinika = "εξωτερικός"
            packHTML(39).HTMLIDIOTHTES(7).values(0).perigrafh = "Καθορίζει ότι το έγγραφο αναφοράς δεν αποτελεί μέρος της τρέχουσας τοποθεσίας"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(1).onoma = "help"
            packHTML(39).HTMLIDIOTHTES(7).values(1).ellinika = "βοήθεια"
            packHTML(39).HTMLIDIOTHTES(7).values(1).perigrafh = "Σύνδεσμοι σε ένα έγγραφο βοήθειας"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(2).onoma = "license"
            packHTML(39).HTMLIDIOTHTES(7).values(2).ellinika = "άδεια"
            packHTML(39).HTMLIDIOTHTES(7).values(2).perigrafh = "Σύνδεσμοι σε πληροφορίες πνευματικών δικαιωμάτων για το έγγραφο"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(3).onoma = "next"
            packHTML(39).HTMLIDIOTHTES(7).values(3).ellinika = "Επόμενο"
            packHTML(39).HTMLIDIOTHTES(7).values(3).perigrafh = "Το επόμενο έγγραφο σε μια επιλογή"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(4).onoma = "nofollow"
            packHTML(39).HTMLIDIOTHTES(7).values(4).ellinika = "μη-εγκεκριμένο"
            packHTML(39).HTMLIDIOTHTES(7).values(4).perigrafh = "Σύνδεσμοι σε μη εγκεκριμένο έγγραφο, όπως σύνδεσμος επί πληρωμή. (Το 'nofollow' χρησιμοποιείται από την Google, για να προσδιορίσει ότι η αράχνη αναζήτησης Google δεν πρέπει να ακολουθεί αυτόν τον σύνδεσμο)"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(5).onoma = "noopener"
            packHTML(39).HTMLIDIOTHTES(7).values(5).ellinika = ""
            packHTML(39).HTMLIDIOTHTES(7).values(5).perigrafh = ""
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(6).onoma = "noreferrer"
            packHTML(39).HTMLIDIOTHTES(7).values(6).ellinika = "δεν-στέλνει-παραπομπής"
            packHTML(39).HTMLIDIOTHTES(7).values(6).perigrafh = "Καθορίζει ότι το πρόγραμμα περιήγησης δεν πρέπει να στέλνει κεφαλίδα παραπομπής HTTP εάν ο χρήστης ακολουθεί την υπερ-σύνδεση"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(7).onoma = "opener"
            packHTML(39).HTMLIDIOTHTES(7).values(7).ellinika = ""
            packHTML(39).HTMLIDIOTHTES(7).values(7).perigrafh = ""
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(8).onoma = "prev"
            packHTML(39).HTMLIDIOTHTES(7).values(8).ellinika = "προηγούμενο"
            packHTML(39).HTMLIDIOTHTES(7).values(8).perigrafh = "Το προηγούμενο έγγραφο σε μια επιλογή"
            '--------- VALUES -------'
            packHTML(39).HTMLIDIOTHTES(7).values(9).onoma = "search"
            packHTML(39).HTMLIDIOTHTES(7).values(9).ellinika = "αναζήτηση"
            packHTML(39).HTMLIDIOTHTES(7).values(9).perigrafh = "Σύνδεσμοι σε ένα εργαλείο αναζήτησης για το έγγραφο"
            '--------- VALUES target -------'
            packHTML(39).HTMLIDIOTHTES(8).values = packHTML(2).HTMLIDIOTHTES(7).values

#End Region


#End Region
#Region "<h1>"
            ReDim packHTML(40).HTMLIDIOTHTES(-1)
            packHTML(40).Etiketa = "<h1>"
            packHTML(40).onomasia = "επικεφαλίδων1"
            packHTML(40).ELtrans = "<επικεφαλίδων1>"
            packHTML(40).Perigrafh = "Οι ετικέτες <h1> έως <h6> χρησιμοποιούνται για τον ορισμό επικεφαλίδων HTML."
            packHTML(40).Syndesmos = ""
#End Region
#Region "<h2>"
            ReDim packHTML(41).HTMLIDIOTHTES(-1)
            packHTML(41).Etiketa = "<h2>"
            packHTML(41).onomasia = "επικεφαλίδων2"
            packHTML(41).ELtrans = "<επικεφαλίδων2>"
            packHTML(41).Perigrafh = "Οι ετικέτες <h1> έως <h6> χρησιμοποιούνται για τον ορισμό επικεφαλίδων HTML."
            packHTML(41).Syndesmos = ""
#End Region
#Region "<h3>"
            ReDim packHTML(42).HTMLIDIOTHTES(-1)
            packHTML(42).Etiketa = "<h3>"
            packHTML(42).onomasia = "επικεφαλίδων3"
            packHTML(42).ELtrans = "<επικεφαλίδων3>"
            packHTML(42).Perigrafh = "επικεφαλίδων"
            packHTML(42).Syndesmos = ""
#End Region
#Region "<h4>"
            ReDim packHTML(43).HTMLIDIOTHTES(-1)
            packHTML(43).Etiketa = "<h3>"
            packHTML(43).onomasia = "επικεφαλίδων4"
            packHTML(43).ELtrans = "<επικεφαλίδων4>"
            packHTML(43).Perigrafh = "Οι ετικέτες <h1> έως <h6> χρησιμοποιούνται για τον ορισμό επικεφαλίδων HTML."
            packHTML(43).Syndesmos = ""
#End Region
#Region "<h5>"
            ReDim packHTML(44).HTMLIDIOTHTES(-1)
            packHTML(44).Etiketa = "<h5>"
            packHTML(44).onomasia = "επικεφαλίδων5"
            packHTML(44).ELtrans = "<επικεφαλίδων5>"
            packHTML(44).Perigrafh = "Οι ετικέτες <h1> έως <h6> χρησιμοποιούνται για τον ορισμό επικεφαλίδων HTML."
            packHTML(44).Syndesmos = ""
#End Region
#Region "<h6>"
            ReDim packHTML(45).HTMLIDIOTHTES(-1)
            packHTML(45).Etiketa = "<h6>"
            packHTML(45).onomasia = "επικεφαλίδων6"
            packHTML(45).ELtrans = "<επικεφαλίδων6>"
            packHTML(45).Perigrafh = "Οι ετικέτες <h1> έως <h6> χρησιμοποιούνται για τον ορισμό επικεφαλίδων HTML."
            packHTML(45).Syndesmos = ""
#End Region
#Region "<head>"
            ReDim packHTML(46).HTMLIDIOTHTES(-1)
            packHTML(46).Etiketa = "<head>"
            packHTML(46).onomasia = "αρχηγός"
            packHTML(46).ELtrans = "<αρχηγός>"
            packHTML(46).Perigrafh = "Το στοιχείο <head> είναι ένα κοντέινερ για μεταδεδομένα (δεδομένα για δεδομένα) και τοποθετείται μεταξύ της ετικέτας <html> και της ετικέτας <body>."
            packHTML(46).Syndesmos = ""
#End Region
#Region "<header>"
            ReDim packHTML(47).HTMLIDIOTHTES(-1)
            packHTML(47).Etiketa = "<header>"
            packHTML(47).onomasia = "επίκεφαλής"
            packHTML(47).ELtrans = "<επίκεφαλής>"
            packHTML(47).Perigrafh = "Το στοιχείο <header> αντιπροσωπεύει ένα κοντέινερ για εισαγωγικό περιεχόμενο ή ένα σύνολο συνδέσμων πλοήγησης."
            packHTML(47).Syndesmos = ""
#End Region
#Region "<hr>"
            ReDim packHTML(48).HTMLIDIOTHTES(-1)
            packHTML(48).Etiketa = "<hr>"
            packHTML(48).onomasia = "διάλειμμα"
            packHTML(48).ELtrans = "<διάλειμμα>"
            packHTML(48).Perigrafh = "Η ετικέτα <hr> ορίζει ένα θεματικό διάλειμμα σε μια σελίδα HTML (π.χ. μια μετατόπιση θέματος)"
            packHTML(48).Syndesmos = ""
#End Region
#Region "<html>"
            ReDim packHTML(49).HTMLIDIOTHTES(0)
            ReDim packHTML(49).HTMLIDIOTHTES(0).values(0)
            packHTML(49).Etiketa = "<html>"
            packHTML(49).onomasia = "έγγραφο"
            packHTML(49).ELtrans = "<έγγραφο>"
            packHTML(49).Perigrafh = "Η ετικέτα <html> αντιπροσωπεύει τη ρίζα ενός εγγράφου HTML."
            packHTML(49).Syndesmos = ""

            packHTML(49).HTMLIDIOTHTES(0).idiothta = "xmlns"
            packHTML(49).HTMLIDIOTHTES(0).Eltrans = "xmlns"
            packHTML(49).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει το χαρακτηριστικό XML namespace (Εάν θέλετε το περιεχόμενό σας να συμμορφώνεται με XHTML)"
            packHTML(49).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(49).HTMLIDIOTHTES(0).values(0).onoma = "(xmlns)"
            packHTML(49).HTMLIDIOTHTES(0).values(0).ellinika = "(xmlns)"
            packHTML(49).HTMLIDIOTHTES(0).values(0).perigrafh = "Ο χώρος ονομάτων που θα χρησιμοποιηθεί (για έγγραφα XHTML)"
#End Region
#Region "<i>"
            ReDim packHTML(50).HTMLIDIOTHTES(-1)
            packHTML(50).Etiketa = "<i>"
            packHTML(50).onomasia = "πλάγια γραφή"
            packHTML(50).ELtrans = "<πλάγια-γραφή>"
            packHTML(50).Perigrafh = "Η ετικέτα <i> ορίζει ένα μέρος του κειμένου με εναλλακτική φωνή ή διάθεση. Το περιεχόμενο στο εσωτερικό εμφανίζεται συνήθως με πλάγια γραφή."
            packHTML(50).Syndesmos = ""
#End Region
#Region "<iframe>"
            ReDim packHTML(51).HTMLIDIOTHTES(10)
            ReDim packHTML(51).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(51).HTMLIDIOTHTES(1).values(1)
            ReDim packHTML(51).HTMLIDIOTHTES(2).values(1)
            ReDim packHTML(51).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(51).HTMLIDIOTHTES(4).values(1)
            ReDim packHTML(51).HTMLIDIOTHTES(5).values(0)
            ReDim packHTML(51).HTMLIDIOTHTES(6).values(4)
            ReDim packHTML(51).HTMLIDIOTHTES(7).values(11)
            ReDim packHTML(51).HTMLIDIOTHTES(8).values(0)
            ReDim packHTML(51).HTMLIDIOTHTES(9).values(0)
            ReDim packHTML(51).HTMLIDIOTHTES(10).values(0)
            packHTML(51).Etiketa = "<iframe>"
            packHTML(51).onomasia = "ενσωματωμένο πλαίσιο"
            packHTML(51).ELtrans = "<ενσωματωμένο-πλαίσιο>"
            packHTML(51).Perigrafh = "Η ετικέτα <iframe> καθορίζει ένα ενσωματωμένο πλαίσιο."
            packHTML(51).Syndesmos = ""



#Region "ATTRIBUTES"
            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(0).idiothta = "allow"
            packHTML(51).HTMLIDIOTHTES(0).Eltrans = "επιτρέπω"
            packHTML(51).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει μια πολιτική χαρακτηριστικών για το <iframe>"
            packHTML(51).HTMLIDIOTHTES(0).syndesmos = ""

            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(1).idiothta = "allowfullscreen"
            packHTML(51).HTMLIDIOTHTES(1).Eltrans = "πλήρους-οθόνης"
            packHTML(51).HTMLIDIOTHTES(1).Perigrafh = "Ορίστε σε true εάν το <iframe> μπορεί να ενεργοποιήσει τη λειτουργία πλήρους οθόνης καλώντας τη μέθοδο requestFullscreen()"
            packHTML(51).HTMLIDIOTHTES(1).syndesmos = ""
            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(2).idiothta = "allowpaymentrequest"
            packHTML(51).HTMLIDIOTHTES(2).Eltrans = "επιτρεπόμενη-πληρωμής"
            packHTML(51).HTMLIDIOTHTES(2).Perigrafh = "Ορίστε σε true εάν ένα cross-origin <iframe> πρέπει να επιτρέπεται να επικαλείται το API αιτήματος πληρωμής"
            packHTML(51).HTMLIDIOTHTES(2).syndesmos = ""
            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(3).idiothta = "height"
            packHTML(51).HTMLIDIOTHTES(3).Eltrans = "ύψος"
            packHTML(51).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει το ύψος ενός <iframe>. Το προεπιλεγμένο ύψος είναι 150 pixel"
            packHTML(51).HTMLIDIOTHTES(3).syndesmos = ""

            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(4).idiothta = "loading"
            packHTML(51).HTMLIDIOTHTES(4).Eltrans = "φόρτωση"
            packHTML(51).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει εάν ένα πρόγραμμα περιήγησης θα πρέπει να φορτώσει ένα iframe αμέσως ή να αναβάλει τη φόρτωση των iframe έως ότου πληρούνται ορισμένες προϋποθέσεις"
            packHTML(51).HTMLIDIOTHTES(4).syndesmos = ""

            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(5).idiothta = "name"
            packHTML(51).HTMLIDIOTHTES(5).Eltrans = "όνομα"
            packHTML(51).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει το όνομα ενός <iframe>"
            packHTML(51).HTMLIDIOTHTES(5).syndesmos = ""

            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(6).idiothta = "referrerpolicy"
            packHTML(51).HTMLIDIOTHTES(6).Eltrans = "πολιτική-παραπομπής"
            packHTML(51).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει ποιες πληροφορίες παραπομπής θα αποστέλλονται κατά την ανάκτηση του iframe"
            packHTML(51).HTMLIDIOTHTES(6).syndesmos = ""

            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(7).idiothta = "sandbox"
            packHTML(51).HTMLIDIOTHTES(7).Eltrans = "περιορισμών-περιεχόμενο"
            packHTML(51).HTMLIDIOTHTES(7).Perigrafh = "Ενεργοποιεί ένα επιπλέον σύνολο περιορισμών για το περιεχόμενο σε ένα <iframe>"
            packHTML(51).HTMLIDIOTHTES(7).syndesmos = ""

            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(8).idiothta = "src"
            packHTML(51).HTMLIDIOTHTES(8).Eltrans = "διεύθυνση"
            packHTML(51).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει τη διεύθυνση του εγγράφου που θα ενσωματωθεί στο <iframe>"
            packHTML(51).HTMLIDIOTHTES(8).syndesmos = ""

            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(9).idiothta = "srcdoc"
            packHTML(51).HTMLIDIOTHTES(9).Eltrans = "εμφάνιση-περιεχόμενο"
            packHTML(51).HTMLIDIOTHTES(9).Perigrafh = "Καθορίζει το περιεχόμενο HTML της σελίδας που θα εμφανίζεται στο <iframe>"
            packHTML(51).HTMLIDIOTHTES(9).syndesmos = ""

            '--------ATTRIBUTES --------'
            packHTML(51).HTMLIDIOTHTES(10).idiothta = "width"
            packHTML(51).HTMLIDIOTHTES(10).Eltrans = "πλάτος"
            packHTML(51).HTMLIDIOTHTES(10).Perigrafh = "Καθορίζει το πλάτος ενός <iframe>. Το προεπιλεγμένο πλάτος είναι 300 pixel"
            packHTML(51).HTMLIDIOTHTES(10).syndesmos = ""
#End Region
#Region "VALUES"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(1).values(0).onoma = "true"
            packHTML(51).HTMLIDIOTHTES(1).values(0).ellinika = "αληθής"
            packHTML(51).HTMLIDIOTHTES(1).values(0).perigrafh = "Ορίστε σε true εάν το <iframe> μπορεί να ενεργοποιήσει τη λειτουργία πλήρους οθόνης καλώντας τη μέθοδο requestFullscreen()"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(1).values(1).onoma = "false"
            packHTML(51).HTMLIDIOTHTES(1).values(1).ellinika = "ψευδής"
            packHTML(51).HTMLIDIOTHTES(1).values(1).perigrafh = "Ορίστε σε true εάν το <iframe> μπορεί να ενεργοποιήσει τη λειτουργία πλήρους οθόνης καλώντας τη μέθοδο requestFullscreen()"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(2).values(0).onoma = "true"
            packHTML(51).HTMLIDIOTHTES(2).values(0).ellinika = "αληθής"
            packHTML(51).HTMLIDIOTHTES(2).values(0).perigrafh = "Ορίστε σε true εάν ένα cross-origin <iframe> πρέπει να επιτρέπεται να επικαλείται το API αιτήματος πληρωμής"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(2).values(1).onoma = "false"
            packHTML(51).HTMLIDIOTHTES(2).values(1).ellinika = "ψευδής"
            packHTML(51).HTMLIDIOTHTES(2).values(1).perigrafh = "Ορίστε σε true εάν ένα cross-origin <iframe> πρέπει να επιτρέπεται να επικαλείται το API αιτήματος πληρωμής"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(3).values(0).onoma = "(pixels)"
            packHTML(51).HTMLIDIOTHTES(3).values(0).ellinika = "(pixels)"
            packHTML(51).HTMLIDIOTHTES(3).values(0).perigrafh = "Το ύψος του ενσωματωμένου πλαισίου σε pixel (π.χ. ύψος = '100')"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(4).values(0).onoma = "eager"
            packHTML(51).HTMLIDIOTHTES(4).values(0).ellinika = "πρόθυμος"
            packHTML(51).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει εάν ένα πρόγραμμα περιήγησης θα πρέπει να φορτώσει ένα iframe αμέσως ή να αναβάλει τη φόρτωση των iframe έως ότου πληρούνται ορισμένες προϋποθέσεις"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(4).values(1).onoma = "lazy"
            packHTML(51).HTMLIDIOTHTES(4).values(1).ellinika = "τεμπέλης"
            packHTML(51).HTMLIDIOTHTES(4).values(1).perigrafh = "Καθορίζει εάν ένα πρόγραμμα περιήγησης θα πρέπει να φορτώσει ένα iframe αμέσως ή να αναβάλει τη φόρτωση των iframe έως ότου πληρούνται ορισμένες προϋποθέσεις"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(5).values(0).onoma = "(name)"
            packHTML(51).HTMLIDIOTHTES(5).values(0).ellinika = "(όνομα)"
            packHTML(51).HTMLIDIOTHTES(5).values(0).perigrafh = "Καθορίζει ένα όνομα για το <iframe>"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(6).values = packHTML(2).HTMLIDIOTHTES(5).values
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(0).onoma = "(no value)"
            packHTML(51).HTMLIDIOTHTES(7).values(0).ellinika = "(καμία αξία)"
            packHTML(51).HTMLIDIOTHTES(7).values(0).perigrafh = "Εφαρμόζει όλους τους περιορισμούς"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(1).onoma = "allow-forms"
            packHTML(51).HTMLIDIOTHTES(7).values(1).ellinika = "επιτρεπόμενα-έντυπα"
            packHTML(51).HTMLIDIOTHTES(7).values(1).perigrafh = "Επιτρέπει την υποβολή φόρμας"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(2).onoma = "allow-modals"
            packHTML(51).HTMLIDIOTHTES(7).values(2).ellinika = "επιτρέπω-τροπικά"
            packHTML(51).HTMLIDIOTHTES(7).values(2).perigrafh = "Επιτρέπει το άνοιγμα τροπικών παραθύρων"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(3).onoma = "allow-orientation-lock"
            packHTML(51).HTMLIDIOTHTES(7).values(3).ellinika = "επιτρέπω-προσανατολισμός-κλείδωμα"
            packHTML(51).HTMLIDIOTHTES(7).values(3).perigrafh = "Επιτρέπει το κλείδωμα του προσανατολισμού της οθόνης"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(4).onoma = "allow-pointer-lock"
            packHTML(51).HTMLIDIOTHTES(7).values(4).ellinika = "επιτρέπω-δείκτης-κλείδωμα"
            packHTML(51).HTMLIDIOTHTES(7).values(4).perigrafh = "Επιτρέπει τη χρήση του Pointer Lock API"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(5).onoma = "allow-popups"
            packHTML(51).HTMLIDIOTHTES(7).values(5).ellinika = "επιτρέπω-αναδυόμενα-παράθυρα"
            packHTML(51).HTMLIDIOTHTES(7).values(5).perigrafh = "Επιτρέπει τα αναδυόμενα παράθυρα"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(6).onoma = "allow-popups-to-escape-sandbox"
            packHTML(51).HTMLIDIOTHTES(7).values(6).ellinika = "Επιτρέπει-αναδυόμενα-χωρίς-sandbox"
            packHTML(51).HTMLIDIOTHTES(7).values(6).perigrafh = "Επιτρέπει στα αναδυόμενα παράθυρα να ανοίγουν νέα παράθυρα χωρίς να κληρονομούν το sandboxing"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(7).onoma = "allow-presentation"
            packHTML(51).HTMLIDIOTHTES(7).values(7).ellinika = "άδεια-παρουσίαση"
            packHTML(51).HTMLIDIOTHTES(7).values(7).perigrafh = "Επιτρέπει την έναρξη μιας συνεδρίας παρουσίασης"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(8).onoma = "allow-same-origin"
            packHTML(51).HTMLIDIOTHTES(7).values(8).ellinika = "επιτρέπω-ίδια-προέλευση"
            packHTML(51).HTMLIDIOTHTES(7).values(8).perigrafh = "Επιτρέπει το περιεχόμενο iframe να αντιμετωπίζεται ως από την ίδια προέλευση"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(9).onoma = "allow-scripts"
            packHTML(51).HTMLIDIOTHTES(7).values(9).ellinika = "επιτρέπω-σενάρια"
            packHTML(51).HTMLIDIOTHTES(7).values(9).perigrafh = "Επιτρέπει την εκτέλεση σεναρίων"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(10).onoma = "allow-top-navigation"
            packHTML(51).HTMLIDIOTHTES(7).values(10).ellinika = "επιτρέπω-πλοήγηση"
            packHTML(51).HTMLIDIOTHTES(7).values(10).perigrafh = "Επιτρέπει στο περιεχόμενο iframe την πλοήγηση στο πλαίσιο περιήγησής του στο ανώτατο επίπεδο"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(7).values(11).onoma = "allow-top-navigation-by-user-activation"
            packHTML(51).HTMLIDIOTHTES(7).values(11).ellinika = "επιτρέπω-πλοήγηση-από-χρήστη-ενεργοποίηση"
            packHTML(51).HTMLIDIOTHTES(7).values(11).perigrafh = "Επιτρέπει στο περιεχόμενο iframe να πλοηγηθεί στο πλαίσιο περιήγησής του ανώτατου επιπέδου, αλλά μόνο εάν έχει ξεκινήσει από τον χρήστη"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(8).values(0).onoma = "(URL)"
            packHTML(51).HTMLIDIOTHTES(8).values(0).ellinika = "(URL)"
            packHTML(51).HTMLIDIOTHTES(8).values(0).perigrafh = "URL Καθορίζει τη διεύθυνση URL του εγγράφου που θα ενσωματωθεί στο iframe. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε άλλο ιστότοπο (όπως src='http://www.example.com/default.htm') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο μέσα σε έναν ιστότοπο (όπως src='default.htm')"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(9).values(0).onoma = "(HTML_code)"
            packHTML(51).HTMLIDIOTHTES(9).values(0).ellinika = "(HTML_code)"
            packHTML(51).HTMLIDIOTHTES(9).values(0).perigrafh = "Το περιεχόμενο HTML για εμφάνιση στο iframe. Πρέπει να είναι έγκυρη σύνταξη HTML"
            '--------VALUES --------'
            packHTML(51).HTMLIDIOTHTES(10).values(0).onoma = "(pixels)"
            packHTML(51).HTMLIDIOTHTES(10).values(0).ellinika = "(pixels)"
            packHTML(51).HTMLIDIOTHTES(10).values(0).perigrafh = "Το πλάτος σε pixel (όπως '100px' ή απλώς '100')"
#End Region
#End Region
#Region "<img>"
            ReDim packHTML(52).HTMLIDIOTHTES(11)
            ReDim packHTML(52).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(52).HTMLIDIOTHTES(1).values(1)
            ReDim packHTML(52).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(52).HTMLIDIOTHTES(3).values(-1)
            ReDim packHTML(52).HTMLIDIOTHTES(4).values(1)
            ReDim packHTML(52).HTMLIDIOTHTES(5).values(0)
            ReDim packHTML(52).HTMLIDIOTHTES(6).values(4)
            ReDim packHTML(52).HTMLIDIOTHTES(7).values(0)
            ReDim packHTML(52).HTMLIDIOTHTES(8).values(0)
            ReDim packHTML(52).HTMLIDIOTHTES(9).values(0)
            ReDim packHTML(52).HTMLIDIOTHTES(10).values(0)
            ReDim packHTML(52).HTMLIDIOTHTES(11).values(0)
            packHTML(52).Etiketa = "<img>"
            packHTML(52).onomasia = "πλάγια γραφή"
            packHTML(52).ELtrans = "<πλάγια-γραφή>"
            packHTML(52).Perigrafh = "Η ετικέτα <i> ορίζει ένα μέρος του κειμένου με εναλλακτική φωνή ή διάθεση. Το περιεχόμενο στο εσωτερικό εμφανίζεται συνήθως με πλάγια γραφή."
            packHTML(52).Syndesmos = ""
#Region "ATTRIBUTES"
            '---- ATTRIBUTES alt----;
            packHTML(52).HTMLIDIOTHTES(0).idiothta = "alt"
            packHTML(52).HTMLIDIOTHTES(0).Eltrans = "παντα"
            packHTML(52).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ένα εναλλακτικό κείμενο για μια εικόνα"
            packHTML(52).HTMLIDIOTHTES(0).syndesmos = ""

            '---- ATTRIBUTES crossorigin----;
            packHTML(52).HTMLIDIOTHTES(1).idiothta = "crossorigin"
            packHTML(52).HTMLIDIOTHTES(1).Eltrans = "διασταυρούμενη καταγωγή"
            packHTML(52).HTMLIDIOTHTES(1).Perigrafh = "Να επιτρέπεται η χρήση εικόνων από ιστότοπους τρίτων που επιτρέπουν την πρόσβαση μεταξύ προέλευσης με καμβά"
            packHTML(52).HTMLIDIOTHTES(1).syndesmos = ""

            '---- ATTRIBUTES height----;
            packHTML(52).HTMLIDIOTHTES(2).idiothta = "height"
            packHTML(52).HTMLIDIOTHTES(2).Eltrans = "ύψος"
            packHTML(52).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει το ύψος μιας εικόνας"
            packHTML(52).HTMLIDIOTHTES(2).syndesmos = ""

            '---- ATTRIBUTES ismap----;
            packHTML(52).HTMLIDIOTHTES(3).idiothta = "ismap"
            packHTML(52).HTMLIDIOTHTES(3).Eltrans = "χάρτη"
            packHTML(52).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει μια εικόνα ως χάρτη εικόνας από την πλευρά του διακομιστή"
            packHTML(52).HTMLIDIOTHTES(3).syndesmos = ""


            '---- ATTRIBUTES loading----;
            packHTML(52).HTMLIDIOTHTES(4).idiothta = "loading"
            packHTML(52).HTMLIDIOTHTES(4).Eltrans = "φόρτωση"
            packHTML(52).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει εάν ένα πρόγραμμα περιήγησης θα πρέπει να φορτώσει μια εικόνα αμέσως ή να αναβάλει τη φόρτωση των εικόνων έως ότου πληρούνται ορισμένες προϋποθέσεις"
            packHTML(52).HTMLIDIOTHTES(4).syndesmos = ""

            '---- ATTRIBUTES longdesc----;
            packHTML(52).HTMLIDIOTHTES(5).idiothta = "longdesc"
            packHTML(52).HTMLIDIOTHTES(5).Eltrans = "διεύθυνση-περιγραφη"
            packHTML(52).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει μια διεύθυνση URL για μια λεπτομερή περιγραφή μιας εικόνας"
            packHTML(52).HTMLIDIOTHTES(5).syndesmos = ""

            '---- ATTRIBUTES referrerpolicy----;
            packHTML(52).HTMLIDIOTHTES(6).idiothta = "referrerpolicy"
            packHTML(52).HTMLIDIOTHTES(6).Eltrans = "πολιτική-παραπομπής"
            packHTML(52).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει ποιες πληροφορίες παραπομπής θα χρησιμοποιηθούν κατά τη λήψη μιας εικόνας"
            packHTML(52).HTMLIDIOTHTES(6).syndesmos = ""

            '---- ATTRIBUTES sizes----;
            packHTML(52).HTMLIDIOTHTES(7).idiothta = "sizes"
            packHTML(52).HTMLIDIOTHTES(7).Eltrans = "μεγέθη"
            packHTML(52).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει μεγέθη εικόνας για διαφορετικές διατάξεις σελίδας"
            packHTML(52).HTMLIDIOTHTES(7).syndesmos = ""

            '---- ATTRIBUTES src----;
            packHTML(52).HTMLIDIOTHTES(8).idiothta = "src"
            packHTML(52).HTMLIDIOTHTES(8).Eltrans = "διαδρομή"
            packHTML(52).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει τη διαδρομή προς την εικόνα"
            packHTML(52).HTMLIDIOTHTES(8).syndesmos = ""

            '---- ATTRIBUTES srcset----;
            packHTML(52).HTMLIDIOTHTES(9).idiothta = "srcset"
            packHTML(52).HTMLIDIOTHTES(9).Eltrans = "λίστα-αρχείων"
            packHTML(52).HTMLIDIOTHTES(9).Perigrafh = "Καθορίζει μια λίστα αρχείων εικόνας που θα χρησιμοποιηθούν σε διαφορετικές καταστάσεις"
            packHTML(52).HTMLIDIOTHTES(9).syndesmos = ""

            '---- ATTRIBUTES usemap----;
            packHTML(52).HTMLIDIOTHTES(10).idiothta = "usemap"
            packHTML(52).HTMLIDIOTHTES(10).Eltrans = "χάρτη-χρήσης"
            packHTML(52).HTMLIDIOTHTES(10).Perigrafh = "Καθορίζει μια εικόνα ως χάρτη εικόνας από την πλευρά του πελάτη"
            packHTML(52).HTMLIDIOTHTES(10).syndesmos = ""

            '---- ATTRIBUTES width----;
            packHTML(52).HTMLIDIOTHTES(11).idiothta = "width"
            packHTML(52).HTMLIDIOTHTES(11).Eltrans = "πλάτος"
            packHTML(52).HTMLIDIOTHTES(11).Perigrafh = "Καθορίζει το πλάτος μιας εικόνας"
            packHTML(52).HTMLIDIOTHTES(11).syndesmos = ""


#End Region
#Region "VALUES"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(0).values(0).onoma = "(text)"
            packHTML(52).HTMLIDIOTHTES(0).values(0).ellinika = "(text)"
            packHTML(52).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει ένα εναλλακτικό κείμενο για μια εικόνα. Οδηγίες για το εναλλακτικό κείμενο: Το κείμενο πρέπει να περιγράφει την εικόνα εάν η εικόνα περιέχει πληροφορίες Το κείμενο πρέπει να εξηγεί πού πηγαίνει ο σύνδεσμος εάν η εικόνα βρίσκεται μέσα σε ένα στοιχείο <a> Χρησιμοποιήστε το alt=(text) εάν η εικόνα είναι μόνο για διακόσμηση"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(1).values(0).onoma = "anonymous"
            packHTML(52).HTMLIDIOTHTES(1).values(0).ellinika = "Ανώνυμος"
            packHTML(52).HTMLIDIOTHTES(1).values(0).perigrafh = "Να επιτρέπεται η χρήση εικόνων από ιστότοπους τρίτων που επιτρέπουν την πρόσβαση μεταξύ προέλευσης με καμβά"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(1).values(1).onoma = "use-credentials"
            packHTML(52).HTMLIDIOTHTES(1).values(1).ellinika = "χρήση-διαπιστευτήρια"
            packHTML(52).HTMLIDIOTHTES(1).values(1).perigrafh = ""
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(2).values(0).onoma = "(pixels)"
            packHTML(52).HTMLIDIOTHTES(2).values(0).ellinika = "(pixels)"
            packHTML(52).HTMLIDIOTHTES(2).values(0).perigrafh = "Το ύψος σε pixel (π.χ. height='100')"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(4).values(0).onoma = "eager"
            packHTML(52).HTMLIDIOTHTES(4).values(0).ellinika = "πρόθυμος"
            packHTML(52).HTMLIDIOTHTES(4).values(0).perigrafh = "Προκαθορισμένο. Φορτώνει μια εικόνα αμέσως"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(4).values(1).onoma = "lazy"
            packHTML(52).HTMLIDIOTHTES(4).values(1).ellinika = "τεμπέλης"
            packHTML(52).HTMLIDIOTHTES(4).values(1).perigrafh = "Αναβάλετε τη φόρτωση των εικόνων έως ότου πληρούνται ορισμένες προϋποθέσεις"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(5).values(0).onoma = "(string)"
            packHTML(52).HTMLIDIOTHTES(5).values(0).ellinika = "(string)"
            packHTML(52).HTMLIDIOTHTES(5).values(0).perigrafh = "Ένας υπερσύνδεσμος σε μια λεπτομερή περιγραφή μιας εικόνας. Πιθανές τιμές: Ένα αναγνωριστικό σε ένα άλλο στοιχείο Μια απόλυτη διεύθυνση URL - 
οδηγεί σε έναν άλλο ιστότοπο (όπως longdesc='http://www.example.com/description.txt') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο μέσα σε έναν ιστότοπο (όπως longdesc='description.txt')"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(6).values = packHTML(2).HTMLIDIOTHTES(5).values
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(7).values(0).onoma = "(size)"
            packHTML(52).HTMLIDIOTHTES(7).values(0).ellinika = "(sizes)"
            packHTML(52).HTMLIDIOTHTES(7).values(0).perigrafh = "Καθορίζει μεγέθη εικόνας για διαφορετικές διατάξεις σελίδας"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(8).values(0).onoma = "(URL)"
            packHTML(52).HTMLIDIOTHTES(8).values(0).ellinika = "(URL)"
            packHTML(52).HTMLIDIOTHTES(8).values(0).perigrafh = "Καθορίζει τη διαδρομή προς την εικόνα"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(9).values(0).onoma = "(URL-list)"
            packHTML(52).HTMLIDIOTHTES(9).values(0).ellinika = "(URL-list)"
            packHTML(52).HTMLIDIOTHTES(9).values(0).perigrafh = "Καθορίζει μια λίστα αρχείων εικόνας που θα χρησιμοποιηθούν σε διαφορετικές καταστάσεις"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(10).values(0).onoma = "(#mapname)"
            packHTML(52).HTMLIDIOTHTES(10).values(0).ellinika = "(#όνομαχάρτη)"
            packHTML(52).HTMLIDIOTHTES(10).values(0).perigrafh = "Ένας χαρακτήρας κατακερματισμού (#) συν το όνομα του στοιχείου <map> που θα χρησιμοποιηθεί"
            '----------- VALUE --------------
            packHTML(52).HTMLIDIOTHTES(11).values(0).onoma = "(pixels)"
            packHTML(52).HTMLIDIOTHTES(11).values(0).ellinika = "(pixels)"
            packHTML(52).HTMLIDIOTHTES(11).values(0).perigrafh = "Το πλάτος σε pixel (π.χ. width='100')"
#End Region
#End Region
#Region "<input>"
            ReDim packHTML(53).HTMLIDIOTHTES(30)
            ReDim packHTML(53).HTMLIDIOTHTES(0).values(4)
            ReDim packHTML(53).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(2).values(1)
            ReDim packHTML(53).HTMLIDIOTHTES(3).values(-1)
            ReDim packHTML(53).HTMLIDIOTHTES(4).values(-1)
            ReDim packHTML(53).HTMLIDIOTHTES(5).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(6).values(-1)
            ReDim packHTML(53).HTMLIDIOTHTES(7).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(8).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(9).values(2)
            ReDim packHTML(53).HTMLIDIOTHTES(10).values(1)
            ReDim packHTML(53).HTMLIDIOTHTES(11).values(-1)
            ReDim packHTML(53).HTMLIDIOTHTES(12).values(4)
            ReDim packHTML(53).HTMLIDIOTHTES(13).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(14).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(15).values(1)
            ReDim packHTML(53).HTMLIDIOTHTES(16).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(17).values(1)
            ReDim packHTML(53).HTMLIDIOTHTES(18).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(19).values(-1)
            ReDim packHTML(53).HTMLIDIOTHTES(20).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(21).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(22).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(23).values(-1)
            ReDim packHTML(53).HTMLIDIOTHTES(24).values(-1)
            ReDim packHTML(53).HTMLIDIOTHTES(25).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(26).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(27).values(1)
            ReDim packHTML(53).HTMLIDIOTHTES(28).values(21)
            ReDim packHTML(53).HTMLIDIOTHTES(29).values(0)
            ReDim packHTML(53).HTMLIDIOTHTES(30).values(0)
            ReDim packHTML(53).Events(4)
            packHTML(53).Etiketa = "<input>"
            packHTML(53).onomasia = "εισαγωγή"
            packHTML(53).ELtrans = "<εισαγωγή>"
            packHTML(53).Perigrafh = "Η ετικέτα <input> καθορίζει ένα πεδίο εισαγωγής όπου ο χρήστης μπορεί να εισάγει δεδομένα."
            packHTML(53).Syndesmos = ""

#Region "Event"
            packHTML(53).Events(0).onoma = "onchange"
            packHTML(53).Events(0).Ellinika = "αλλάζει-στοιχείο"
            packHTML(53).Events(0).Perigrafh = "Ενεργοποιείται τη στιγμή που αλλάζει η τιμή του στοιχείου"

            packHTML(53).Events(1).onoma = "oninput"
            packHTML(53).Events(1).Ellinika = "εισροή"
            packHTML(53).Events(1).Perigrafh = "Σενάριο που θα εκτελεστεί όταν ένα στοιχείο λαμβάνει είσοδο χρήστη"

            packHTML(53).Events(2).onoma = "oninvalid"
            packHTML(53).Events(2).Ellinika = "μη-έγκυρο"
            packHTML(53).Events(2).Perigrafh = "Σενάριο που εκτελείται όταν ένα στοιχείο δεν είναι έγκυρο"

            packHTML(53).Events(3).onoma = "onselect"
            packHTML(53).Events(3).Ellinika = "επιλογή"
            packHTML(53).Events(3).Perigrafh = "Ενεργοποιείται αφού έχει επιλεγεί κάποιο κείμενο σε ένα στοιχείο"

            packHTML(53).Events(4).onoma = "onsearch"
            packHTML(53).Events(4).Ellinika = "αναζήτησης"
            packHTML(53).Events(4).Perigrafh = "Ενεργοποιείται όταν ο χρήστης γράφει κάτι σε ένα πεδίο αναζήτησης (για <input='search'>)"

#End Region

#Region "ATTRIBUTES"
            '----- ATTRIBUTES accept----
            packHTML(53).HTMLIDIOTHTES(0).idiothta = "accept"
            packHTML(53).HTMLIDIOTHTES(0).Eltrans = "αποδέχομαι"
            packHTML(53).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ένα φίλτρο για τους τύπους αρχείων που μπορεί να επιλέξει ο χρήστης από το πλαίσιο διαλόγου εισαγωγής αρχείου (μόνο για type='file')"
            packHTML(53).HTMLIDIOTHTES(0).syndesmos = ""
            '----- ATTRIBUTES alt----
            packHTML(53).HTMLIDIOTHTES(1).idiothta = "alt"
            packHTML(53).HTMLIDIOTHTES(1).Eltrans = "εναλλακτικό"
            packHTML(53).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει ένα εναλλακτικό κείμενο για εικόνες (μόνο για type='image')"
            packHTML(53).HTMLIDIOTHTES(1).syndesmos = ""
            '----- ATTRIBUTES autocomplete----
            packHTML(53).HTMLIDIOTHTES(2).idiothta = "autocomplete"
            packHTML(53).HTMLIDIOTHTES(2).Eltrans = "αυτόματη-συμπλήρωση"
            packHTML(53).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει εάν ένα στοιχείο <input> θα πρέπει να έχει ενεργοποιημένη την αυτόματη συμπλήρωση"
            packHTML(53).HTMLIDIOTHTES(2).syndesmos = ""
            '----- ATTRIBUTES autofocus----
            packHTML(53).HTMLIDIOTHTES(3).idiothta = "autofocus"
            packHTML(53).HTMLIDIOTHTES(3).Eltrans = "αυτόματη-εστίαση"
            packHTML(53).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει ότι ένα στοιχείο <input> θα πρέπει να εστιάζει αυτόματα κατά τη φόρτωση της σελίδας"
            packHTML(53).HTMLIDIOTHTES(3).syndesmos = ""
            '----- ATTRIBUTES checked----
            packHTML(53).HTMLIDIOTHTES(4).idiothta = "checked"
            packHTML(53).HTMLIDIOTHTES(4).Eltrans = "τσεκαρισμένος"
            packHTML(53).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει ότι ένα στοιχείο <input> θα πρέπει να προεπιλέγεται κατά τη φόρτωση της σελίδας (για type='checkbox' ή type='radio'"
            packHTML(53).HTMLIDIOTHTES(4).syndesmos = ""
            '----- ATTRIBUTES checked----
            packHTML(53).HTMLIDIOTHTES(5).idiothta = "dirname"
            packHTML(53).HTMLIDIOTHTES(5).Eltrans = "κατεύθυνση-κειμένου"
            packHTML(53).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει ότι θα υποβληθεί η κατεύθυνση κειμένου"
            packHTML(53).HTMLIDIOTHTES(5).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(6).idiothta = "disabled"
            packHTML(53).HTMLIDIOTHTES(6).Eltrans = "απενεργοποιημένο"
            packHTML(53).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει ότι ένα στοιχείο <input> πρέπει να είναι απενεργοποιημένο"
            packHTML(53).HTMLIDIOTHTES(6).syndesmos = ""
            '----- ATTRIBUTES form----
            packHTML(53).HTMLIDIOTHTES(7).idiothta = "form"
            packHTML(53).HTMLIDIOTHTES(7).Eltrans = "φόρμα"
            packHTML(53).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει τη μορφή στην οποία ανήκει το στοιχείο <input>"
            packHTML(53).HTMLIDIOTHTES(7).syndesmos = ""
            '----- ATTRIBUTES formaction----
            packHTML(53).HTMLIDIOTHTES(8).idiothta = "formaction"
            packHTML(53).HTMLIDIOTHTES(8).Eltrans = "σχηματισμός"
            packHTML(53).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει τη διεύθυνση URL του αρχείου που θα επεξεργαστεί το στοιχείο ελέγχου εισόδου κατά την υποβολή της φόρμας (για type='submit' και type='image')"
            packHTML(53).HTMLIDIOTHTES(8).syndesmos = ""
            '----- ATTRIBUTES formenctype----
            packHTML(53).HTMLIDIOTHTES(9).idiothta = "formenctype"
            packHTML(53).HTMLIDIOTHTES(9).Eltrans = "μορφομορφότυπος"
            packHTML(53).HTMLIDIOTHTES(9).Perigrafh = "Specifies how the form-data should be encoded when submitting it to the server (for type='submit' and type='image')"
            packHTML(53).HTMLIDIOTHTES(9).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(10).idiothta = "formmethod"
            packHTML(53).HTMLIDIOTHTES(10).Eltrans = "μέθοδος-μορφής"
            packHTML(53).HTMLIDIOTHTES(10).Perigrafh = "Καθορίζει τον τρόπο με τον οποίο θα πρέπει να κωδικοποιούνται τα δεδομένα φόρμας κατά την υποβολή τους στον διακομιστή (για type='submit' και type='image')"
            packHTML(53).HTMLIDIOTHTES(10).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(11).idiothta = "formnovalidate "
            packHTML(53).HTMLIDIOTHTES(11).Eltrans = "στοιχεία-δεν-επικυρώνονται"
            packHTML(53).HTMLIDIOTHTES(11).Perigrafh = "Ορίζει ότι τα στοιχεία φόρμας δεν πρέπει να επικυρώνονται κατά την υποβολή"
            packHTML(53).HTMLIDIOTHTES(11).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(12).idiothta = "formtargetv"
            packHTML(53).HTMLIDIOTHTES(12).Eltrans = "μορφή-στόχου"
            packHTML(53).HTMLIDIOTHTES(12).Perigrafh = "Καθορίζει πού θα εμφανίζεται η απάντηση που λαμβάνεται μετά την υποβολή της φόρμας (για type='submit' και type='image')"
            packHTML(53).HTMLIDIOTHTES(12).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(13).idiothta = "height"
            packHTML(53).HTMLIDIOTHTES(13).Eltrans = "ύψος"
            packHTML(53).HTMLIDIOTHTES(13).Perigrafh = "Καθορίζει το ύψος ενός στοιχείου <input> (μόνο για type='image')"
            packHTML(53).HTMLIDIOTHTES(13).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(14).idiothta = "list"
            packHTML(53).HTMLIDIOTHTES(14).Eltrans = "λίστα"
            packHTML(53).HTMLIDIOTHTES(14).Perigrafh = "Αναφέρεται σε ένα στοιχείο <datalist> που περιέχει προκαθορισμένες επιλογές για ένα στοιχείο <input>"
            packHTML(53).HTMLIDIOTHTES(14).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(15).idiothta = "max"
            packHTML(53).HTMLIDIOTHTES(15).Eltrans = "Μέγιστη"
            packHTML(53).HTMLIDIOTHTES(15).Perigrafh = "Καθορίζει τη μέγιστη τιμή για ένα στοιχείο <input>"
            packHTML(53).HTMLIDIOTHTES(15).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(16).idiothta = "maxlength"
            packHTML(53).HTMLIDIOTHTES(16).Eltrans = "μέγιστο-μήκος"
            packHTML(53).HTMLIDIOTHTES(16).Perigrafh = "Καθορίζει τον μέγιστο αριθμό χαρακτήρων που επιτρέπεται σε ένα στοιχείο <input>"
            packHTML(53).HTMLIDIOTHTES(16).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(17).idiothta = "min"
            packHTML(53).HTMLIDIOTHTES(17).Eltrans = "ελάχιστη"
            packHTML(53).HTMLIDIOTHTES(17).Perigrafh = "Καθορίζει μια ελάχιστη τιμή για ένα στοιχείο <input>"
            packHTML(53).HTMLIDIOTHTES(17).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(18).idiothta = "minlength"
            packHTML(53).HTMLIDIOTHTES(18).Eltrans = "ελαχιστο-μήκος"
            packHTML(53).HTMLIDIOTHTES(18).Perigrafh = "Καθορίζει τον ελάχιστο αριθμό χαρακτήρων που απαιτείται σε ένα στοιχείο <input>"
            packHTML(53).HTMLIDIOTHTES(18).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(19).idiothta = "multiple"
            packHTML(53).HTMLIDIOTHTES(19).Eltrans = "πολλαπλούς"
            packHTML(53).HTMLIDIOTHTES(19).Perigrafh = "Καθορίζει ότι ένας χρήστης μπορεί να εισάγει περισσότερες από μία τιμές σε ένα στοιχείο <input>"
            packHTML(53).HTMLIDIOTHTES(19).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(20).idiothta = "name"
            packHTML(53).HTMLIDIOTHTES(20).Eltrans = "όνομα"
            packHTML(53).HTMLIDIOTHTES(20).Perigrafh = "Καθορίζει το όνομα ενός στοιχείου <input>"
            packHTML(53).HTMLIDIOTHTES(20).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(21).idiothta = "pattern"
            packHTML(53).HTMLIDIOTHTES(21).Eltrans = "πρότυπο"
            packHTML(53).HTMLIDIOTHTES(21).Perigrafh = "Καθορίζει μια τυπική έκφραση με την οποία ελέγχεται η τιμή ενός στοιχείου <input>"
            packHTML(53).HTMLIDIOTHTES(21).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(22).idiothta = "placeholder"
            packHTML(53).HTMLIDIOTHTES(22).Eltrans = "κράτησης-θέσης"
            packHTML(53).HTMLIDIOTHTES(22).Perigrafh = "Καθορίζει μια σύντομη υπόδειξη που περιγράφει την αναμενόμενη τιμή ενός στοιχείου <input>"
            packHTML(53).HTMLIDIOTHTES(22).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(23).idiothta = "readonly"
            packHTML(53).HTMLIDIOTHTES(23).Eltrans = "μόνο για ανάγνωση"
            packHTML(53).HTMLIDIOTHTES(23).Perigrafh = "Καθορίζει ότι ένα πεδίο εισαγωγής είναι μόνο για ανάγνωση"
            packHTML(53).HTMLIDIOTHTES(23).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(24).idiothta = "required"
            packHTML(53).HTMLIDIOTHTES(24).Eltrans = "απαιτείται"
            packHTML(53).HTMLIDIOTHTES(24).Perigrafh = "Καθορίζει ότι ένα πεδίο εισαγωγής πρέπει να συμπληρωθεί πριν από την υποβολή της φόρμας"
            packHTML(53).HTMLIDIOTHTES(24).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(25).idiothta = "size"
            packHTML(53).HTMLIDIOTHTES(25).Eltrans = "Μέγεθος"
            packHTML(53).HTMLIDIOTHTES(25).Perigrafh = "Καθορίζει το πλάτος, σε χαρακτήρες, ενός στοιχείου <input>"
            packHTML(53).HTMLIDIOTHTES(25).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(26).idiothta = "src"
            packHTML(53).HTMLIDIOTHTES(26).Eltrans = "διεύθυνση"
            packHTML(53).HTMLIDIOTHTES(26).Perigrafh = "Καθορίζει τη διεύθυνση URL της εικόνας που θα χρησιμοποιηθεί ως κουμπί υποβολής (μόνο για type='image')"
            packHTML(53).HTMLIDIOTHTES(26).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(27).idiothta = "step"
            packHTML(53).HTMLIDIOTHTES(27).Eltrans = "βήμα"
            packHTML(53).HTMLIDIOTHTES(27).Perigrafh = "Καθορίζει το διάστημα μεταξύ νόμιμων αριθμών σε ένα πεδίο εισαγωγής"
            packHTML(53).HTMLIDIOTHTES(27).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(28).idiothta = "type"
            packHTML(53).HTMLIDIOTHTES(28).Eltrans = "τύπος"
            packHTML(53).HTMLIDIOTHTES(28).Perigrafh = "Καθορίζει τον τύπο στοιχείου <input> που θα εμφανίζεται"
            packHTML(53).HTMLIDIOTHTES(28).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(29).idiothta = "value"
            packHTML(53).HTMLIDIOTHTES(29).Eltrans = "αξία"
            packHTML(53).HTMLIDIOTHTES(29).Perigrafh = "Καθορίζει την τιμή ενός στοιχείου <input>"
            packHTML(53).HTMLIDIOTHTES(29).syndesmos = ""
            '----- ATTRIBUTES ----
            packHTML(53).HTMLIDIOTHTES(30).idiothta = "width"
            packHTML(53).HTMLIDIOTHTES(30).Eltrans = "πλάτος"
            packHTML(53).HTMLIDIOTHTES(30).Perigrafh = "Καθορίζει το πλάτος ενός στοιχείου <input> (μόνο για type='image')"
            packHTML(53).HTMLIDIOTHTES(30).syndesmos = ""
            '----- ATTRIBUTES ----

#End Region
#Region "VALUE"
            packHTML(53).HTMLIDIOTHTES(0).values(0).onoma = "(file_extension)"
            packHTML(53).HTMLIDIOTHTES(0).values(0).ellinika = "(επέκταση-αρχείου)"
            packHTML(53).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίστε τις επεκτάσεις αρχείου (π.χ.: .gif, .jpg, .png, .doc) από τις οποίες μπορεί να επιλέξει ο χρήστης"

            packHTML(53).HTMLIDIOTHTES(0).values(1).onoma = "(audio/*)"
            packHTML(53).HTMLIDIOTHTES(0).values(1).ellinika = "(audio/*)"
            packHTML(53).HTMLIDIOTHTES(0).values(1).perigrafh = "Ο χρήστης μπορεί να επιλέξει όλα τα αρχεία ήχου"

            packHTML(53).HTMLIDIOTHTES(0).values(2).onoma = "(video/*)"
            packHTML(53).HTMLIDIOTHTES(0).values(2).ellinika = "(video/*)"
            packHTML(53).HTMLIDIOTHTES(0).values(2).perigrafh = "Ο χρήστης μπορεί να επιλέξει όλα τα αρχεία βίντεο"

            packHTML(53).HTMLIDIOTHTES(0).values(3).onoma = "(image/*)"
            packHTML(53).HTMLIDIOTHTES(0).values(3).ellinika = "(image/*)"
            packHTML(53).HTMLIDIOTHTES(0).values(3).perigrafh = "Ο χρήστης μπορεί να επιλέξει όλα τα αρχεία εικόνας"

            packHTML(53).HTMLIDIOTHTES(0).values(4).onoma = "(media_type)"
            packHTML(53).HTMLIDIOTHTES(0).values(4).ellinika = "(media_type)"
            packHTML(53).HTMLIDIOTHTES(0).values(4).perigrafh = "Ένας έγκυρος τύπος μέσου, χωρίς παραμέτρους. Ανατρέξτε στο IANA Media Types για μια πλήρη λίστα με τυπικούς τύπους μέσων"

            packHTML(53).HTMLIDIOTHTES(1).values(0).onoma = "(text)"
            packHTML(53).HTMLIDIOTHTES(1).values(0).ellinika = "(text)"
            packHTML(53).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει ένα εναλλακτικό κείμενο για την εικόνα"

            packHTML(53).HTMLIDIOTHTES(2).values(0).onoma = "on"
            packHTML(53).HTMLIDIOTHTES(2).values(0).ellinika = "ενεργοποιημένη"
            packHTML(53).HTMLIDIOTHTES(2).values(0).perigrafh = "Προκαθορισμένο. Καθορίζει ότι η αυτόματη συμπλήρωση είναι ενεργοποιημένη (ενεργοποιημένη)"

            packHTML(53).HTMLIDIOTHTES(2).values(1).onoma = "off"
            packHTML(53).HTMLIDIOTHTES(2).values(1).ellinika = "απενεργοποιημένη"
            packHTML(53).HTMLIDIOTHTES(2).values(1).perigrafh = "Καθορίζει ότι η αυτόματη συμπλήρωση είναι απενεργοποιημένη (απενεργοποιημένη)"

            packHTML(53).HTMLIDIOTHTES(5).values(0).onoma = "(name.dir)"
            packHTML(53).HTMLIDIOTHTES(5).values(0).ellinika = "(name.dir)"
            packHTML(53).HTMLIDIOTHTES(5).values(0).perigrafh = "Καθορίζει ότι θα υποβληθεί η κατεύθυνση κειμένου του πεδίου εισαγωγής."

            packHTML(53).HTMLIDIOTHTES(7).values(0).onoma = "(form_id)"
            packHTML(53).HTMLIDIOTHTES(7).values(0).ellinika = "(form_id)"
            packHTML(53).HTMLIDIOTHTES(7).values(0).perigrafh = "Καθορίζει το στοιχείο φόρμας στο οποίο ανήκει το στοιχείο <input>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο."

            packHTML(53).HTMLIDIOTHTES(8).values(0).onoma = "(URL)"
            packHTML(53).HTMLIDIOTHTES(8).values(0).ellinika = "(URL)"
            packHTML(53).HTMLIDIOTHTES(8).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL του αρχείου που θα επεξεργαστεί το στοιχείο ελέγχου εισόδου κατά την υποβολή της φόρμας. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - η πλήρης διεύθυνση μιας σελίδας (όπως href='http://www.example.com/formresult.asp') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο στον τρέχοντα ιστότοπο (όπως href='formresult.asp')"

            packHTML(53).HTMLIDIOTHTES(9).values = packHTML(16).HTMLIDIOTHTES(4).values

            packHTML(53).HTMLIDIOTHTES(10).values = packHTML(16).HTMLIDIOTHTES(5).values


            packHTML(53).HTMLIDIOTHTES(12).values = packHTML(16).HTMLIDIOTHTES(7).values

            packHTML(53).HTMLIDIOTHTES(13).values(0).onoma = "(pixels)"
            packHTML(53).HTMLIDIOTHTES(13).values(0).ellinika = "(pixels)"
            packHTML(53).HTMLIDIOTHTES(13).values(0).perigrafh = "Το ύψος σε pixel (π.χ. height='100')"

            packHTML(53).HTMLIDIOTHTES(14).values(0).onoma = "(datalist_id)"
            packHTML(53).HTMLIDIOTHTES(14).values(0).ellinika = "(datalist_id)"
            packHTML(53).HTMLIDIOTHTES(14).values(0).perigrafh = "Καθορίζει το αναγνωριστικό της λίστας δεδομένων στην οποία θα συνδεθεί το στοιχείο <input>"

            packHTML(53).HTMLIDIOTHTES(15).values(0).onoma = "(number)"
            packHTML(53).HTMLIDIOTHTES(15).values(0).ellinika = "(number)"
            packHTML(53).HTMLIDIOTHTES(15).values(0).perigrafh = "Καθορίζει τη μέγιστη επιτρεπόμενη τιμή"

            packHTML(53).HTMLIDIOTHTES(15).values(1).onoma = "(date)"
            packHTML(53).HTMLIDIOTHTES(15).values(1).ellinika = "(date)"
            packHTML(53).HTMLIDIOTHTES(15).values(1).perigrafh = "Καθορίζει τη μέγιστη επιτρεπόμενη ημερομηνία"

            packHTML(53).HTMLIDIOTHTES(16).values(0).onoma = "(number)"
            packHTML(53).HTMLIDIOTHTES(16).values(0).ellinika = "(number)"
            packHTML(53).HTMLIDIOTHTES(16).values(0).perigrafh = "Ο μέγιστος επιτρεπόμενος αριθμός χαρακτήρων στο στοιχείο <input>. Η προεπιλεγμένη τιμή είναι 524288"

            packHTML(53).HTMLIDIOTHTES(17).values(0).onoma = "(number)"
            packHTML(53).HTMLIDIOTHTES(17).values(0).ellinika = "(number)"
            packHTML(53).HTMLIDIOTHTES(17).values(0).perigrafh = "Καθορίζει την ελάχιστη επιτρεπόμενη τιμή"

            packHTML(53).HTMLIDIOTHTES(17).values(1).onoma = "(date)"
            packHTML(53).HTMLIDIOTHTES(17).values(1).ellinika = "(date)"
            packHTML(53).HTMLIDIOTHTES(17).values(1).perigrafh = "Καθορίζει την ελάχιστη επιτρεπόμενη ημερομηνία"

            packHTML(53).HTMLIDIOTHTES(18).values(0).onoma = "(number)"
            packHTML(53).HTMLIDIOTHTES(18).values(0).ellinika = "(number)"
            packHTML(53).HTMLIDIOTHTES(18).values(0).perigrafh = "Ο ελάχιστος αριθμός χαρακτήρων που απαιτείται σε ένα στοιχείο <input>"

            packHTML(53).HTMLIDIOTHTES(20).values(0).onoma = "(text)"
            packHTML(53).HTMLIDIOTHTES(20).values(0).ellinika = "(text)"
            packHTML(53).HTMLIDIOTHTES(20).values(0).perigrafh = "Καθορίζει το όνομα του στοιχείου <input>"

            packHTML(53).HTMLIDIOTHTES(21).values(0).onoma = "(regexp)"
            packHTML(53).HTMLIDIOTHTES(21).values(0).ellinika = "(regexp)"
            packHTML(53).HTMLIDIOTHTES(21).values(0).perigrafh = "Καθορίζει μια τυπική έκφραση με την οποία ελέγχεται η τιμή του στοιχείου <input>"

            packHTML(53).HTMLIDIOTHTES(22).values(0).onoma = "(text)"
            packHTML(53).HTMLIDIOTHTES(22).values(0).ellinika = "(text)"
            packHTML(53).HTMLIDIOTHTES(22).values(0).perigrafh = "Καθορίζει μια σύντομη υπόδειξη που περιγράφει την αναμενόμενη τιμή του πεδίου εισαγωγής"

            packHTML(53).HTMLIDIOTHTES(25).values(0).onoma = "(number)"
            packHTML(53).HTMLIDIOTHTES(25).values(0).ellinika = "(number)"
            packHTML(53).HTMLIDIOTHTES(25).values(0).perigrafh = "Καθορίζει το πλάτος ενός στοιχείου <input>, σε χαρακτήρες. Η προεπιλεγμένη τιμή είναι 20"

            packHTML(53).HTMLIDIOTHTES(26).values(0).onoma = "(URL)"
            packHTML(53).HTMLIDIOTHTES(26).values(0).ellinika = "(URL)"
            packHTML(53).HTMLIDIOTHTES(26).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL της εικόνας που θα χρησιμοποιηθεί ως κουμπί υποβολής. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως src='http://www.example.com/submit.gif') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο μέσα σε έναν ιστότοπο (όπως src='submit.gif')"

            packHTML(53).HTMLIDIOTHTES(27).values(0).onoma = "(number)"
            packHTML(53).HTMLIDIOTHTES(27).values(0).ellinika = "(number)"
            packHTML(53).HTMLIDIOTHTES(27).values(0).perigrafh = "Καθορίζει το διάστημα μεταξύ νόμιμων αριθμών στο πεδίο εισαγωγής. Η προεπιλογή είναι 1"

            packHTML(53).HTMLIDIOTHTES(27).values(1).onoma = "any"
            packHTML(53).HTMLIDIOTHTES(27).values(1).ellinika = "κάθε"
            packHTML(53).HTMLIDIOTHTES(27).values(1).perigrafh = ""

            packHTML(53).HTMLIDIOTHTES(28).values(0).onoma = "button"
            packHTML(53).HTMLIDIOTHTES(28).values(0).ellinika = "κουμπί"
            packHTML(53).HTMLIDIOTHTES(28).values(0).perigrafh = "Ορίζει ένα κουμπί με δυνατότητα κλικ (που χρησιμοποιείται κυρίως με JavaScript για την ενεργοποίηση ενός σεναρίου)"

            packHTML(53).HTMLIDIOTHTES(28).values(1).onoma = "checkbox"
            packHTML(53).HTMLIDIOTHTES(28).values(1).ellinika = "πλαίσιο ελέγχου"
            packHTML(53).HTMLIDIOTHTES(28).values(1).perigrafh = "Ορίζει ένα πλαίσιο ελέγχου"

            packHTML(53).HTMLIDIOTHTES(28).values(2).onoma = "color"
            packHTML(53).HTMLIDIOTHTES(28).values(2).ellinika = "χρώμα"
            packHTML(53).HTMLIDIOTHTES(28).values(2).perigrafh = "Ορίζει έναν επιλογέα χρώματος"

            packHTML(53).HTMLIDIOTHTES(28).values(3).onoma = "date"
            packHTML(53).HTMLIDIOTHTES(28).values(3).ellinika = "ημερομηνία"
            packHTML(53).HTMLIDIOTHTES(28).values(3).perigrafh = "Καθορίζει έναν έλεγχο ημερομηνίας (έτος, μήνας, ημέρα (χωρίς ώρα))"

            packHTML(53).HTMLIDIOTHTES(28).values(4).onoma = "datetime-local"
            packHTML(53).HTMLIDIOTHTES(28).values(4).ellinika = "ημερομηνία-ώρα-τοπική"
            packHTML(53).HTMLIDIOTHTES(28).values(4).perigrafh = "Καθορίζει έναν έλεγχο ημερομηνίας και ώρας (έτος, μήνας, ημέρα, ώρα (χωρίς ζώνη ώρας)"

            packHTML(53).HTMLIDIOTHTES(28).values(5).onoma = "email"
            packHTML(53).HTMLIDIOTHTES(28).values(5).ellinika = "ΗΛΕΚΤΡΟΝΙΚΗ-ΔΙΕΥΘΥΝΣΗ"
            packHTML(53).HTMLIDIOTHTES(28).values(5).perigrafh = "Καθορίζει ένα πεδίο για μια διεύθυνση e-mail"

            packHTML(53).HTMLIDIOTHTES(28).values(6).onoma = "file"
            packHTML(53).HTMLIDIOTHTES(28).values(6).ellinika = "αρχείο"
            packHTML(53).HTMLIDIOTHTES(28).values(6).perigrafh = "Καθορίζει ένα πεδίο επιλογής αρχείου και ένα κουμπί 'Αναζήτηση' (για μεταφορτώσεις αρχείων)"

            packHTML(53).HTMLIDIOTHTES(28).values(7).onoma = "hidden"
            packHTML(53).HTMLIDIOTHTES(28).values(7).ellinika = "κρυμμένος"
            packHTML(53).HTMLIDIOTHTES(28).values(7).perigrafh = "Ορίζει ένα κρυφό πεδίο εισαγωγής"

            packHTML(53).HTMLIDIOTHTES(28).values(8).onoma = "image"
            packHTML(53).HTMLIDIOTHTES(28).values(8).ellinika = "εικόνα"
            packHTML(53).HTMLIDIOTHTES(28).values(8).perigrafh = "Ορίζει μια εικόνα ως το κουμπί υποβολής"

            packHTML(53).HTMLIDIOTHTES(28).values(9).onoma = "month"
            packHTML(53).HTMLIDIOTHTES(28).values(9).ellinika = "μήνας"
            packHTML(53).HTMLIDIOTHTES(28).values(9).perigrafh = "Καθορίζει έλεγχο μήνα και έτους (χωρίς ζώνη ώρας)"


            packHTML(53).HTMLIDIOTHTES(28).values(10).onoma = "number"
            packHTML(53).HTMLIDIOTHTES(28).values(10).ellinika = "αριθμός"
            packHTML(53).HTMLIDIOTHTES(28).values(10).perigrafh = "Ορίζει ένα πεδίο για την εισαγωγή ενός αριθμού"

            packHTML(53).HTMLIDIOTHTES(28).values(11).onoma = "password"
            packHTML(53).HTMLIDIOTHTES(28).values(11).ellinika = "Κωδικός-πρόσβασης"
            packHTML(53).HTMLIDIOTHTES(28).values(11).perigrafh = "Ορίζει ένα πεδίο κωδικού πρόσβασης"

            packHTML(53).HTMLIDIOTHTES(28).values(12).onoma = "radio"
            packHTML(53).HTMLIDIOTHTES(28).values(12).ellinika = "κουμπί-επιλογής"
            packHTML(53).HTMLIDIOTHTES(28).values(12).perigrafh = "Ορίζει ένα κουμπί επιλογής"

            packHTML(53).HTMLIDIOTHTES(28).values(13).onoma = "range"
            packHTML(53).HTMLIDIOTHTES(28).values(13).ellinika = "εύρος"
            packHTML(53).HTMLIDIOTHTES(28).values(13).perigrafh = "Ορίζει ένα στοιχείο ελέγχου εύρους (όπως ένα στοιχείο ελέγχου ρυθμιστικού)"

            packHTML(53).HTMLIDIOTHTES(28).values(14).onoma = "reset"
            packHTML(53).HTMLIDIOTHTES(28).values(14).ellinika = "επαναφορά"
            packHTML(53).HTMLIDIOTHTES(28).values(14).perigrafh = "Ορίζει ένα κουμπί επαναφοράς"

            packHTML(53).HTMLIDIOTHTES(28).values(15).onoma = "search"
            packHTML(53).HTMLIDIOTHTES(28).values(15).ellinika = "Αναζήτηση"
            packHTML(53).HTMLIDIOTHTES(28).values(15).perigrafh = "Ορίζει ένα πεδίο κειμένου για την εισαγωγή μιας συμβολοσειράς αναζήτησης"

            packHTML(53).HTMLIDIOTHTES(28).values(16).onoma = "submit"
            packHTML(53).HTMLIDIOTHTES(28).values(16).ellinika = "κουμπί-υποβολής"
            packHTML(53).HTMLIDIOTHTES(28).values(16).perigrafh = "Ορίζει ένα κουμπί υποβολής"

            packHTML(53).HTMLIDIOTHTES(28).values(17).onoma = "tel"
            packHTML(53).HTMLIDIOTHTES(28).values(17).ellinika = "τηλ"
            packHTML(53).HTMLIDIOTHTES(28).values(17).perigrafh = "Καθορίζει ένα πεδίο για την εισαγωγή αριθμού τηλεφώνου"

            packHTML(53).HTMLIDIOTHTES(28).values(18).onoma = "κείμενο"
            packHTML(53).HTMLIDIOTHTES(28).values(18).ellinika = "κείμενο"
            packHTML(53).HTMLIDIOTHTES(28).values(18).perigrafh = "Προκαθορισμένο. Ορίζει ένα πεδίο κειμένου μιας γραμμής"

            packHTML(53).HTMLIDIOTHTES(28).values(19).onoma = "time"
            packHTML(53).HTMLIDIOTHTES(28).values(19).ellinika = "χρόνος"
            packHTML(53).HTMLIDIOTHTES(28).values(19).perigrafh = "Ορίζει ένα στοιχείο ελέγχου για την εισαγωγή ώρας (χωρίς ζώνη ώρας)"

            packHTML(53).HTMLIDIOTHTES(28).values(20).onoma = "url"
            packHTML(53).HTMLIDIOTHTES(28).values(20).ellinika = "διεύθυνσης"
            packHTML(53).HTMLIDIOTHTES(28).values(20).perigrafh = "Καθορίζει ένα πεδίο για την εισαγωγή μιας διεύθυνσης URL"

            packHTML(53).HTMLIDIOTHTES(28).values(21).onoma = "week"
            packHTML(53).HTMLIDIOTHTES(28).values(21).ellinika = "εβδομάδα"
            packHTML(53).HTMLIDIOTHTES(28).values(21).perigrafh = "Καθορίζει έλεγχο εβδομάδας και έτους (χωρίς ζώνη ώρας)"

            packHTML(53).HTMLIDIOTHTES(29).values(0).onoma = "(text)"
            packHTML(53).HTMLIDIOTHTES(29).values(0).ellinika = "(text)"
            packHTML(53).HTMLIDIOTHTES(29).values(0).perigrafh = "Καθορίζει την τιμή του στοιχείου <input>"

            packHTML(53).HTMLIDIOTHTES(30).values(0).onoma = "(pixels)"
            packHTML(53).HTMLIDIOTHTES(30).values(0).ellinika = "(pixels)"
            packHTML(53).HTMLIDIOTHTES(30).values(0).perigrafh = "Το πλάτος σε pixel (π.χ. width='100')"





#End Region

#End Region
#Region "<ins>"
            ReDim packHTML(54).HTMLIDIOTHTES(1)
            ReDim packHTML(54).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(54).HTMLIDIOTHTES(1).values(0)
            packHTML(54).Etiketa = "<ins>"
            packHTML(54).onomasia = "υπογραμμίση"
            packHTML(54).ELtrans = "<υπογραμμίση>"
            packHTML(54).Perigrafh = "Καθορίζει ένα κείμενο που έχει εισαχθεί σε ένα έγγραφο"
            packHTML(54).Syndesmos = ""

            packHTML(54).HTMLIDIOTHTES(0).idiothta = "cite"
            packHTML(54).HTMLIDIOTHTES(0).Eltrans = "αναφορά"
            packHTML(54).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει μια διεύθυνση URL σε ένα έγγραφο που εξηγεί τον λόγο για την εισαγωγή/αλλαγή του κειμένου"
            packHTML(54).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(54).HTMLIDIOTHTES(1).idiothta = "datetime"
            packHTML(54).HTMLIDIOTHTES(1).Eltrans = "ημερομηνία-ώρα"
            packHTML(54).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει την ημερομηνία και την ώρα κατά την οποία έγινε εισαγωγή/αλλαγή του κειμένου"
            packHTML(54).HTMLIDIOTHTES(1).syndesmos = "Καθορίζει τη διεύθυνση στο έγγραφο που εξηγεί γιατί εισήχθη/αλλάχθηκε το κείμενο. Πιθανές τιμές: Ένα απόλυτο URL - οδηγεί σε έναν άλλο ιστότοπο (όπως cite='http://www.example.com') Μια σχετική διεύθυνση URL - οδηγεί σε μια σελίδα σε έναν ιστότοπο (όπως cite='example.html')"

            packHTML(54).HTMLIDIOTHTES(0).values(0).onoma = "(URL)"
            packHTML(54).HTMLIDIOTHTES(0).values(0).ellinika = "(URL)"
            packHTML(54).HTMLIDIOTHTES(0).values(0).perigrafh = ""

            packHTML(54).HTMLIDIOTHTES(1).values(0).onoma = "(YYYY-MM-DDThh:mm:ssTZD)"
            packHTML(54).HTMLIDIOTHTES(1).values(0).ellinika = "(YYYY-MM-DDThh:mm:ssTZD)"
            packHTML(54).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει την ημερομηνία και την ώρα κατά την οποία έγινε εισαγωγή/αλλαγή του κειμένου. Επεξήγηση των εξαρτημάτων: ΕΕΕΕ - έτος (π.χ. 2009) ΜΜ - μήνας (π.χ. 01 Ιανουαρίου) ΗΗ - ημέρα του μήνα (π.χ. 08) T ή ένα διάστημα - ένα διαχωριστικό (απαιτείται εάν έχει επίσης καθοριστεί ο χρόνος) ωω - ώρα (π.χ. 22 για τις 22:00) mm - λεπτά (π.χ. 55) ss - δευτερόλεπτα (π.χ. 03) TZD - Προσδιορισμός ζώνης ώρας (το Z υποδηλώνει τα Ζουλού, γνωστό και ως Μέση ώρα Γκρίνουιτς)"

#End Region
#Region "<kbd>"
            ReDim packHTML(54).HTMLIDIOTHTES(-1)
            packHTML(54).Etiketa = "<kbd>"
            packHTML(54).onomasia = "πληκτρολογίου"
            packHTML(54).ELtrans = "<πληκτρολογίου>"
            packHTML(54).Perigrafh = "Η ετικέτα <kbd> χρησιμοποιείται για να ορίσει την είσοδο πληκτρολογίου. Το περιεχόμενο στο εσωτερικό εμφανίζεται στην προεπιλεγμένη γραμματοσειρά monospace του προγράμματος περιήγησης."
            packHTML(54).Syndesmos = ""
#End Region
#Region "<label>"
            ReDim packHTML(55).HTMLIDIOTHTES(1)
            ReDim packHTML(55).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(55).HTMLIDIOTHTES(1).values(0)
            packHTML(55).Etiketa = "<label>"
            packHTML(55).onomasia = "επιγραφή"
            packHTML(55).ELtrans = "<επιγραφή>"
            packHTML(55).Perigrafh = "Καθορίζει μια ετικέτα για ένα στοιχείο <input>"
            packHTML(55).Syndesmos = ""

            packHTML(55).HTMLIDIOTHTES(0).idiothta = "for"
            packHTML(55).HTMLIDIOTHTES(0).Eltrans = "Για"
            packHTML(55).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει το αναγνωριστικό του στοιχείου φόρμας στο οποίο θα πρέπει να συνδεθεί η ετικέτα"
            packHTML(55).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(55).HTMLIDIOTHTES(1).idiothta = "form"
            packHTML(55).HTMLIDIOTHTES(1).Eltrans = "φόρμα"
            packHTML(55).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει σε ποια μορφή ανήκει η ετικέτα"
            packHTML(55).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(55).HTMLIDIOTHTES(0).values(0).onoma = "(element_id)"
            packHTML(55).HTMLIDIOTHTES(0).values(0).ellinika = "(element_id)"
            packHTML(55).HTMLIDIOTHTES(0).values(0).perigrafh = "Το αναγνωριστικό του στοιχείου στο οποίο δεσμεύεται η ετικέτα"

            packHTML(55).HTMLIDIOTHTES(0).values(0).onoma = "(form_id)"
            packHTML(55).HTMLIDIOTHTES(0).values(0).ellinika = "(form_id)"
            packHTML(55).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει το στοιχείο φόρμας στο οποίο ανήκει το στοιχείο <label>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο"
#End Region
#Region "<legend>"
            ReDim packHTML(56).HTMLIDIOTHTES(-1)
            packHTML(56).Etiketa = "<legend>"
            packHTML(56).onomasia = "λεζάντα"
            packHTML(56).ELtrans = "<λεζάντα>"
            packHTML(56).Perigrafh = "Ορίστε μια λεζάντα για ένα στοιχείο <fieldset>"
            packHTML(56).Syndesmos = ""
#End Region
#Region "<li>"
            ReDim packHTML(57).HTMLIDIOTHTES(0)
            ReDim packHTML(57).HTMLIDIOTHTES(0).values(0)
            packHTML(57).Etiketa = "<li>"
            packHTML(57).onomasia = "λίστας"
            packHTML(57).ELtrans = "<λίστας>"
            packHTML(57).Perigrafh = "Η ετικέτα <li> ορίζει ένα στοιχείο λίστας."
            packHTML(57).Syndesmos = ""

            packHTML(57).HTMLIDIOTHTES(0).idiothta = "value"
            packHTML(57).HTMLIDIOTHTES(0).Eltrans = "αξία"
            packHTML(57).HTMLIDIOTHTES(0).Perigrafh = "Μόνο για λίστες <ol>. Καθορίζει την τιμή έναρξης ενός στοιχείου λίστας. Τα ακόλουθα στοιχεία της λίστας θα αυξηθούν από αυτόν τον αριθμό"
            packHTML(57).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(57).HTMLIDIOTHTES(0).values(0).onoma = "(number)"
            packHTML(57).HTMLIDIOTHTES(0).values(0).ellinika = "(number)"
            packHTML(57).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει την τιμή του στοιχείου της λίστας"
#End Region
#Region "<link>"
            ReDim packHTML(58).HTMLIDIOTHTES(8)
            ReDim packHTML(58).HTMLIDIOTHTES(0).values(1)
            ReDim packHTML(58).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(58).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(58).HTMLIDIOTHTES(3).values(6)
            ReDim packHTML(58).HTMLIDIOTHTES(4).values(24)
            ReDim packHTML(58).HTMLIDIOTHTES(5).values(14)
            ReDim packHTML(58).HTMLIDIOTHTES(6).values(1)
            ReDim packHTML(58).HTMLIDIOTHTES(7).values(0)
            ReDim packHTML(58).HTMLIDIOTHTES(8).values(0)
            packHTML(58).Etiketa = "<link>"
            packHTML(58).onomasia = "Σύνδεσμος"
            packHTML(58).ELtrans = "<Σύνδεσμος>"
            packHTML(58).Perigrafh = "Η ετικέτα <link> ορίζει τη σχέση μεταξύ του τρέχοντος εγγράφου και ενός εξωτερικού πόρου."
            packHTML(58).Syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(0).idiothta = "crossorigin"
            packHTML(58).HTMLIDIOTHTES(0).Eltrans = "διασταυρούμενη-καταγωγή"
            packHTML(58).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τον τρόπο με τον οποίο το στοιχείο χειρίζεται αιτήματα πολλαπλής προέλευσης"
            packHTML(58).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(1).idiothta = "href"
            packHTML(58).HTMLIDIOTHTES(1).Eltrans = "συνδεδεμένου"
            packHTML(58).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει τη θέση του συνδεδεμένου εγγράφου"
            packHTML(58).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(2).idiothta = "hreflang"
            packHTML(58).HTMLIDIOTHTES(2).Eltrans = "συνδεδεμένο-γλώσσα"
            packHTML(58).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει τη γλώσσα του κειμένου στο συνδεδεμένο έγγραφο"
            packHTML(58).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(3).idiothta = "media"
            packHTML(58).HTMLIDIOTHTES(3).Eltrans = "ΜΑΖΙΚΗΣ-ΕΝΗΜΕΡΩΣΗΣ"
            packHTML(58).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει σε ποια συσκευή θα εμφανίζεται το συνδεδεμένο έγγραφο"
            packHTML(58).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(4).idiothta = "referrerpolicy"
            packHTML(58).HTMLIDIOTHTES(4).Eltrans = "πολιτική-παραπομπής"
            packHTML(58).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει ποιος σύνδεσμος παραπομπής θα χρησιμοποιηθεί κατά την ανάκτηση του πόρου"
            packHTML(58).HTMLIDIOTHTES(4).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(5).idiothta = "rel"
            packHTML(58).HTMLIDIOTHTES(5).Eltrans = "σχέση"
            packHTML(58).HTMLIDIOTHTES(5).Perigrafh = "Απαιτείται. Καθορίζει τη σχέση μεταξύ του τρέχοντος εγγράφου και του συνδεδεμένου εγγράφου"
            packHTML(58).HTMLIDIOTHTES(5).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(6).idiothta = "sizes"
            packHTML(58).HTMLIDIOTHTES(6).Eltrans = "μεγέθη"
            packHTML(58).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει το μέγεθος του συνδεδεμένου πόρου. Μόνο για rel='εικονίδιο'"
            packHTML(58).HTMLIDIOTHTES(6).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(7).idiothta = "title"
            packHTML(58).HTMLIDIOTHTES(7).Eltrans = "τίτλος"
            packHTML(58).HTMLIDIOTHTES(7).Perigrafh = "Ορίζει ένα προτιμώμενο ή ένα εναλλακτικό φύλλο στυλ"
            packHTML(58).HTMLIDIOTHTES(7).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(8).idiothta = "type"
            packHTML(58).HTMLIDIOTHTES(8).Eltrans = "τύπος"
            packHTML(58).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει τον τύπο μέσου του συνδεδεμένου εγγράφου"
            packHTML(58).HTMLIDIOTHTES(8).syndesmos = ""

            packHTML(58).HTMLIDIOTHTES(0).values(0).onoma = "anonymous"
            packHTML(58).HTMLIDIOTHTES(0).values(0).ellinika = "Ανώνυμος"
            packHTML(58).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει τον τρόπο με τον οποίο το στοιχείο χειρίζεται αιτήματα πολλαπλής προέλευσης"

            packHTML(58).HTMLIDIOTHTES(0).values(1).onoma = "use-credentials"
            packHTML(58).HTMLIDIOTHTES(0).values(1).ellinika = "χρήση-διαπιστευτήρια"
            packHTML(58).HTMLIDIOTHTES(0).values(1).perigrafh = "Καθορίζει τον τρόπο με τον οποίο το στοιχείο χειρίζεται αιτήματα πολλαπλής προέλευσης"

            packHTML(58).HTMLIDIOTHTES(1).values(0).onoma = "(URL)"
            packHTML(58).HTMLIDIOTHTES(1).values(0).ellinika = "(URL)"
            packHTML(58).HTMLIDIOTHTES(1).values(0).perigrafh = "Το URL του συνδεδεμένου πόρου/εγγράφου. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως href='http://www.example.com/theme.css') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο σε έναν ιστότοπο (όπως href='/themes/theme.css')"

            packHTML(58).HTMLIDIOTHTES(2).values(0).onoma = "(language_code)"
            packHTML(58).HTMLIDIOTHTES(2).values(0).ellinika = "(language_code)"
            packHTML(58).HTMLIDIOTHTES(2).values(0).perigrafh = "Ένας κωδικός γλώσσας δύο γραμμάτων που καθορίζει τη γλώσσα του συνδεδεμένου εγγράφου"

            packHTML(58).HTMLIDIOTHTES(3).values = packHTML(2).HTMLIDIOTHTES(3).values

            packHTML(58).HTMLIDIOTHTES(4).values = packHTML(2).HTMLIDIOTHTES(5).values

            packHTML(58).HTMLIDIOTHTES(5).values(0).onoma = "alternate"
            packHTML(58).HTMLIDIOTHTES(5).values(0).ellinika = "εναλλακτικό"
            packHTML(58).HTMLIDIOTHTES(5).values(0).perigrafh = "Παρέχει έναν σύνδεσμο προς μια εναλλακτική έκδοση του εγγράφου (π.χ. σελίδα εκτύπωσης, μετάφραση ή καθρέφτης).
Παράδειγμα: <link rel='alternate' type='application/atom+xml' title='W3Schools News' href='/blog/news/atom'>"

            packHTML(58).HTMLIDIOTHTES(5).values(1).onoma = "author"
            packHTML(58).HTMLIDIOTHTES(5).values(1).ellinika = "συγγραφέας"
            packHTML(58).HTMLIDIOTHTES(5).values(1).perigrafh = "Παρέχει έναν σύνδεσμο προς τον συντάκτη του εγγράφου"

            packHTML(58).HTMLIDIOTHTES(5).values(2).onoma = "dns-prefetch"
            packHTML(58).HTMLIDIOTHTES(5).values(2).ellinika = "προανάκτηση-dns"
            packHTML(58).HTMLIDIOTHTES(5).values(2).perigrafh = "Καθορίζει ότι το πρόγραμμα περιήγησης πρέπει να εκτελεί προληπτικά ανάλυση DNS για την προέλευση του πόρου προορισμού"

            packHTML(58).HTMLIDIOTHTES(5).values(3).onoma = "help"
            packHTML(58).HTMLIDIOTHTES(5).values(3).ellinika = "βοήθεια"
            packHTML(58).HTMLIDIOTHTES(5).values(3).perigrafh = "Παρέχει έναν σύνδεσμο προς ένα έγγραφο βοήθειας. Παράδειγμα: <link rel='help' href='/help/'>"

            packHTML(58).HTMLIDIOTHTES(5).values(4).onoma = "icon"
            packHTML(58).HTMLIDIOTHTES(5).values(4).ellinika = "εικόνισμα"
            packHTML(58).HTMLIDIOTHTES(5).values(4).perigrafh = "Εισάγει ένα εικονίδιο για την αναπαράσταση του εγγράφου. Παράδειγμα: <link rel='icon' href='favicon.ico' type='image/x-icon'>"

            packHTML(58).HTMLIDIOTHTES(5).values(5).onoma = "license"
            packHTML(58).HTMLIDIOTHTES(5).values(5).ellinika = "άδεια"
            packHTML(58).HTMLIDIOTHTES(5).values(5).perigrafh = "Παρέχει έναν σύνδεσμο προς πληροφορίες πνευματικών δικαιωμάτων για το έγγραφο"

            packHTML(58).HTMLIDIOTHTES(5).values(6).onoma = "next"
            packHTML(58).HTMLIDIOTHTES(5).values(6).ellinika = "Επόμενο"
            packHTML(58).HTMLIDIOTHTES(5).values(6).perigrafh = "Παρέχει έναν σύνδεσμο προς το επόμενο έγγραφο της σειράς"

            packHTML(58).HTMLIDIOTHTES(5).values(7).onoma = "pingback"
            packHTML(58).HTMLIDIOTHTES(5).values(7).ellinika = "πινκπίσω"
            packHTML(58).HTMLIDIOTHTES(5).values(7).perigrafh = "Παρέχει τη διεύθυνση του διακομιστή pingback που χειρίζεται τις επιστροφές ping στο τρέχον έγγραφο"

            packHTML(58).HTMLIDIOTHTES(5).values(8).onoma = "preconnect"
            packHTML(58).HTMLIDIOTHTES(5).values(8).ellinika = "προσύνδεση"
            packHTML(58).HTMLIDIOTHTES(5).values(8).perigrafh = "Καθορίζει ότι το πρόγραμμα περιήγησης θα πρέπει να συνδέεται προληπτικά με την προέλευση του πόρου προορισμού."

            packHTML(58).HTMLIDIOTHTES(5).values(9).onoma = "prefetch"
            packHTML(58).HTMLIDIOTHTES(5).values(9).ellinika = "προανάκτηση"
            packHTML(58).HTMLIDIOTHTES(5).values(9).perigrafh = "Καθορίζει ότι το πρόγραμμα περιήγησης θα πρέπει προληπτικά να ανακτά και να αποθηκεύει προσωρινά τον πόρο προορισμού, καθώς είναι πιθανό να απαιτείται για μια πλοήγηση παρακολούθησης"

            packHTML(58).HTMLIDIOTHTES(5).values(10).onoma = "preload"
            packHTML(58).HTMLIDIOTHTES(5).values(10).ellinika = "προφόρτιση"
            packHTML(58).HTMLIDIOTHTES(5).values(10).perigrafh = "Καθορίζει ότι ο πράκτορας του προγράμματος περιήγησης πρέπει προληπτικά να ανακτήσει και να αποθηκεύσει προσωρινά τον πόρο προορισμού για την τρέχουσα πλοήγηση σύμφωνα με τον προορισμό που δίνεται από το χαρακτηριστικό 'ως' (και την προτεραιότητα που σχετίζεται με αυτόν τον προορισμό)."

            packHTML(58).HTMLIDIOTHTES(5).values(11).onoma = "prerender"
            packHTML(58).HTMLIDIOTHTES(5).values(11).ellinika = "προαπόδοση"
            packHTML(58).HTMLIDIOTHTES(5).values(11).perigrafh = "Καθορίζει ότι το πρόγραμμα περιήγησης θα πρέπει να προ-απόδοση (φόρτωση) της καθορισμένης ιστοσελίδας στο παρασκήνιο. Έτσι, εάν ο χρήστης πλοηγηθεί σε αυτήν τη σελίδα, επιταχύνει τη φόρτωση της σελίδας (επειδή η σελίδα έχει ήδη φορτωθεί). Προειδοποίηση! Αυτό σπαταλά το εύρος ζώνης του χρήστη! Χρησιμοποιήστε την προαπόδοση μόνο εάν είστε απολύτως βέβαιοι ότι η ιστοσελίδα απαιτείται σε κάποιο σημείο της διαδρομής του χρήστη"

            packHTML(58).HTMLIDIOTHTES(5).values(12).onoma = "prev"
            packHTML(58).HTMLIDIOTHTES(5).values(12).ellinika = "προηγούμενο"
            packHTML(58).HTMLIDIOTHTES(5).values(12).perigrafh = "Υποδεικνύει ότι το έγγραφο είναι μέρος μιας σειράς και ότι το προηγούμενο έγγραφο της σειράς είναι το έγγραφο αναφοράς"

            packHTML(58).HTMLIDIOTHTES(5).values(13).onoma = "search"
            packHTML(58).HTMLIDIOTHTES(5).values(13).ellinika = "Αναζήτηση"
            packHTML(58).HTMLIDIOTHTES(5).values(13).perigrafh = "Παρέχει έναν σύνδεσμο προς έναν πόρο που μπορεί να χρησιμοποιηθεί για αναζήτηση στο τρέχον έγγραφο και στις σχετικές σελίδες του."

            packHTML(58).HTMLIDIOTHTES(5).values(14).onoma = "stylesheet"
            packHTML(58).HTMLIDIOTHTES(5).values(14).ellinika = "φύλλο-στυλ"
            packHTML(58).HTMLIDIOTHTES(5).values(14).perigrafh = "Εισάγει ένα φύλλο στυλ"

            packHTML(58).HTMLIDIOTHTES(6).values(0).onoma = "HeightxWidth"
            packHTML(58).HTMLIDIOTHTES(6).values(0).ellinika = "μεγέθη"
            packHTML(58).HTMLIDIOTHTES(6).values(0).perigrafh = "Καθορίζει το μέγεθος του συνδεδεμένου πόρου. Μόνο για rel='εικονίδιο'"

            packHTML(58).HTMLIDIOTHTES(6).values(1).onoma = "any"
            packHTML(58).HTMLIDIOTHTES(6).values(1).ellinika = "κάθε"
            packHTML(58).HTMLIDIOTHTES(6).values(1).perigrafh = "Καθορίζει το μέγεθος του συνδεδεμένου πόρου. Μόνο για rel='εικονίδιο'"

            packHTML(58).HTMLIDIOTHTES(7).values(0).onoma = "title"
            packHTML(58).HTMLIDIOTHTES(7).values(0).ellinika = "τίτλος"
            packHTML(58).HTMLIDIOTHTES(7).values(0).perigrafh = "Ορίζει ένα προτιμώμενο ή ένα εναλλακτικό φύλλο στυλ"

            packHTML(58).HTMLIDIOTHTES(8).values(0).onoma = "(media_type)"
            packHTML(58).HTMLIDIOTHTES(8).values(0).ellinika = "(media_type)"
            packHTML(58).HTMLIDIOTHTES(8).values(0).perigrafh = "Ο τύπος μέσου του συνδεδεμένου εγγράφου. Ανατρέξτε στο IANA Media Types για μια πλήρη λίστα με τυπικούς τύπους μέσων"


#End Region
#Region "<main>"
            ReDim packHTML(59).HTMLIDIOTHTES(-1)
            packHTML(59).Etiketa = "<main>"
            packHTML(59).onomasia = "κύριος"
            packHTML(59).ELtrans = "<κύριος>"
            packHTML(59).Perigrafh = "Καθορίζει το κύριο περιεχόμενο ενός εγγράφου"
            packHTML(59).Syndesmos = ""
#End Region
#Region "<map>"
            ReDim packHTML(60).HTMLIDIOTHTES(-1)
            packHTML(60).Etiketa = "<map>"
            packHTML(60).onomasia = "χάρτης"
            packHTML(60).ELtrans = "<χάρτης>"
            packHTML(60).Perigrafh = "Η ετικέτα <map> χρησιμοποιείται για τον ορισμό ενός χάρτη εικόνας. Ένας χάρτης εικόνας είναι μια εικόνα με περιοχές με δυνατότητα κλικ."
            packHTML(60).Syndesmos = ""
#End Region
#Region "<mark>"
            ReDim packHTML(61).HTMLIDIOTHTES(-1)
            packHTML(61).Etiketa = "<mark>"
            packHTML(61).onomasia = "σημάδι"
            packHTML(61).ELtrans = "<σημάδι>"
            packHTML(61).Perigrafh = "Η ετικέτα <mark> ορίζει κείμενο που πρέπει να επισημανθεί ή να επισημανθεί."
            packHTML(61).Syndesmos = ""
#End Region
#Region "<meta>"
            ReDim packHTML(62).HTMLIDIOTHTES(3)
            ReDim packHTML(62).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(62).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(62).HTMLIDIOTHTES(2).values(3)
            ReDim packHTML(62).HTMLIDIOTHTES(3).values(5)
            packHTML(62).Etiketa = "<meta>"
            packHTML(62).onomasia = "μεταδεδομένα"
            packHTML(62).ELtrans = "<μεταδεδομένα>"
            packHTML(62).Perigrafh = "Η ετικέτα <meta> ορίζει μεταδεδομένα για ένα έγγραφο HTML. Τα μεταδεδομένα είναι δεδομένα (πληροφορίες) σχετικά με δεδομένα"
            packHTML(62).Syndesmos = ""

            packHTML(62).HTMLIDIOTHTES(0).idiothta = "charset"
            packHTML(62).HTMLIDIOTHTES(0).Eltrans = "σύνολο χαρακτήρων"
            packHTML(62).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει την κωδικοποίηση χαρακτήρων για το έγγραφο HTML"
            packHTML(62).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(62).HTMLIDIOTHTES(1).idiothta = "content"
            packHTML(62).HTMLIDIOTHTES(1).Eltrans = "περιεχόμενο"
            packHTML(62).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει την τιμή που σχετίζεται με το χαρακτηριστικό http-equiv ή name"
            packHTML(62).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(62).HTMLIDIOTHTES(2).idiothta = "http-equiv"
            packHTML(62).HTMLIDIOTHTES(2).Eltrans = "http-equiv"
            packHTML(62).HTMLIDIOTHTES(2).Perigrafh = "Παρέχει μια κεφαλίδα HTTP για τις πληροφορίες/την τιμή του χαρακτηριστικού περιεχομένου"
            packHTML(62).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(62).HTMLIDIOTHTES(3).idiothta = "name"
            packHTML(62).HTMLIDIOTHTES(3).Eltrans = "όνομα"
            packHTML(62).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει ένα όνομα για τα μεταδεδομένα"
            packHTML(62).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(62).HTMLIDIOTHTES(0).values(0).onoma = "(character_set)"
            packHTML(62).HTMLIDIOTHTES(0).values(0).ellinika = "(character_set)"
            packHTML(62).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει την κωδικοποίηση χαρακτήρων για το έγγραφο HTML. Η προδιαγραφή HTML5 ενθαρρύνει τους προγραμματιστές ιστού να χρησιμοποιούν το σύνολο χαρακτήρων UTF-8!"

            packHTML(62).HTMLIDIOTHTES(1).values(0).onoma = "(text)"
            packHTML(62).HTMLIDIOTHTES(1).values(0).ellinika = "(text)"
            packHTML(62).HTMLIDIOTHTES(1).values(0).perigrafh = "Το περιεχόμενο των μεταπληροφοριών"

            packHTML(62).HTMLIDIOTHTES(2).values(0).onoma = "content-security-policy"
            packHTML(62).HTMLIDIOTHTES(2).values(0).ellinika = "περιεχόμενο-ασφάλεια-πολιτική"
            packHTML(62).HTMLIDIOTHTES(2).values(0).perigrafh = "πολιτική Καθορίζει μια πολιτική περιεχομένου για το έγγραφο.
Παράδειγμα: <meta http-equiv='content-security-policy' content='default-src 'self''>"

            packHTML(62).HTMLIDIOTHTES(2).values(1).onoma = "content-type"
            packHTML(62).HTMLIDIOTHTES(2).values(1).ellinika = "Τύπος-περιεχομένου"
            packHTML(62).HTMLIDIOTHTES(2).values(1).perigrafh = "Καθορίζει την κωδικοποίηση χαρακτήρων για το έγγραφο.
Παράδειγμα: <meta http-equiv='content-type' content='text/html; charset=UTF-8'>"

            packHTML(62).HTMLIDIOTHTES(2).values(2).onoma = "default-style"
            packHTML(62).HTMLIDIOTHTES(2).values(2).ellinika = "προεπιλεγμένου-στυλ"
            packHTML(62).HTMLIDIOTHTES(2).values(2).perigrafh = "Προσδιόρισε το προτιμώμενο φύλλο στυλ που θα χρησιμοποιηθεί. Παράδειγμα: <meta http-equiv='default-style' content='προτιμώμενο φύλλο στυλ του εγγράφου'> Σημείωση: Η τιμή του χαρακτηριστικού περιεχομένου παραπάνω πρέπει να ταιριάζει με την τιμή του χαρακτηριστικού τίτλου σε ένα στοιχείο συνδέσμου στο ίδιο έγγραφο ή πρέπει να ταιριάζει με την τιμή του χαρακτηριστικού τίτλου σε ένα στοιχείο στυλ στο ίδιο έγγραφο."

            packHTML(62).HTMLIDIOTHTES(2).values(3).onoma = "refresh"
            packHTML(62).HTMLIDIOTHTES(2).values(3).ellinika = "φρεσκάρω"
            packHTML(62).HTMLIDIOTHTES(2).values(3).perigrafh = "Καθορίζει ένα χρονικό διάστημα για την ανανέωση του εγγράφου. Παράδειγμα: <meta http-equiv='refresh' content='300'> Σημείωση: Η τιμή 'refresh πρέπει να χρησιμοποιείται προσεκτικά, καθώς αφαιρεί τον έλεγχο μιας σελίδας από τον χρήστη. Η χρήση 'ανανέωσης' θα προκαλέσει αποτυχία στις Οδηγίες προσβασιμότητας περιεχομένου Ιστού του W3C."

            packHTML(62).HTMLIDIOTHTES(3).values(0).onoma = "application-name"
            packHTML(62).HTMLIDIOTHTES(3).values(0).ellinika = "Όνομα-εφαρμογής"
            packHTML(62).HTMLIDIOTHTES(3).values(0).perigrafh = "Καθορίζει το όνομα της εφαρμογής Web που αντιπροσωπεύει η σελίδα"


            packHTML(62).HTMLIDIOTHTES(3).values(1).onoma = "author"
            packHTML(62).HTMLIDIOTHTES(3).values(1).ellinika = "συγγραφέας"
            packHTML(62).HTMLIDIOTHTES(3).values(1).perigrafh = "Καθορίζει το όνομα του συντάκτη του εγγράφου."

            packHTML(62).HTMLIDIOTHTES(3).values(2).onoma = "description"
            packHTML(62).HTMLIDIOTHTES(3).values(2).ellinika = "περιγραφή"
            packHTML(62).HTMLIDIOTHTES(3).values(2).perigrafh = "Καθορίζει μια περιγραφή της σελίδας. Οι μηχανές αναζήτησης μπορούν να πάρουν αυτήν την περιγραφή για να εμφανιστεί με τα αποτελέσματα των αναζητήσεων"

            packHTML(62).HTMLIDIOTHTES(3).values(3).onoma = "generator"
            packHTML(62).HTMLIDIOTHTES(3).values(3).ellinika = "γεννήτρια"
            packHTML(62).HTMLIDIOTHTES(3).values(3).perigrafh = "Καθορίζει ένα από τα πακέτα λογισμικού που χρησιμοποιούνται για τη δημιουργία του εγγράφου (δεν χρησιμοποιείται σε σελίδες που έχουν συνταχθεί με το χέρι)"

            packHTML(62).HTMLIDIOTHTES(3).values(4).onoma = "keywords"
            packHTML(62).HTMLIDIOTHTES(3).values(4).ellinika = "λέξεις-κλειδιά"
            packHTML(62).HTMLIDIOTHTES(3).values(4).perigrafh = "Καθορίζει μια λίστα λέξεων-κλειδιών διαχωρισμένων με κόμματα - σχετικές με τη σελίδα (Πληροφορεί τις μηχανές αναζήτησης σχετικά με τη σελίδα)."

            packHTML(62).HTMLIDIOTHTES(3).values(5).onoma = "viewport"
            packHTML(62).HTMLIDIOTHTES(3).values(5).ellinika = "θέαση"
            packHTML(62).HTMLIDIOTHTES(3).values(5).perigrafh = "Ελέγχει τη θύρα προβολής (την ορατή περιοχή μιας ιστοσελίδας από τον χρήστη). Η θύρα προβολής διαφέρει ανάλογα με τη συσκευή και θα είναι μικρότερη σε ένα κινητό τηλέφωνο από ότι σε μια οθόνη υπολογιστή."

#End Region
#Region "<meter>"
            ReDim packHTML(63).HTMLIDIOTHTES(6)
            ReDim packHTML(63).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(63).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(63).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(63).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(63).HTMLIDIOTHTES(4).values(0)
            ReDim packHTML(63).HTMLIDIOTHTES(5).values(0)
            ReDim packHTML(63).HTMLIDIOTHTES(6).values(0)
            packHTML(63).Etiketa = "<meter>"
            packHTML(63).onomasia = "μετρητής"
            packHTML(63).ELtrans = "<μετρητής>"
            packHTML(63).Perigrafh = "Η ετικέτα <meter> ορίζει μια βαθμωτή μέτρηση σε ένα γνωστό εύρος ή μια κλασματική τιμή. Αυτό είναι επίσης γνωστό ως μετρητής"
            packHTML(63).Syndesmos = ""

            packHTML(63).HTMLIDIOTHTES(0).idiothta = "form"
            packHTML(63).HTMLIDIOTHTES(0).Eltrans = "φόρμα"
            packHTML(63).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει σε ποια μορφή ανήκει το στοιχείο <meter>"
            packHTML(63).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(63).HTMLIDIOTHTES(1).idiothta = "high"
            packHTML(63).HTMLIDIOTHTES(1).Eltrans = "υψηλός"
            packHTML(63).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει το εύρος που θεωρείται υψηλή τιμή"
            packHTML(63).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(63).HTMLIDIOTHTES(2).idiothta = "low"
            packHTML(63).HTMLIDIOTHTES(2).Eltrans = "χαμηλός"
            packHTML(63).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει το εύρος που θεωρείται χαμηλή τιμή"
            packHTML(63).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(63).HTMLIDIOTHTES(3).idiothta = "max"
            packHTML(63).HTMLIDIOTHTES(3).Eltrans = "Μέγιστη"
            packHTML(63).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει τη μέγιστη τιμή του εύρους"
            packHTML(63).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(63).HTMLIDIOTHTES(4).idiothta = "min"
            packHTML(63).HTMLIDIOTHTES(4).Eltrans = "ελάχιστη"
            packHTML(63).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει την ελάχιστη τιμή του εύρους. Η προεπιλεγμένη τιμή είναι 0"
            packHTML(63).HTMLIDIOTHTES(4).syndesmos = ""

            packHTML(63).HTMLIDIOTHTES(5).idiothta = "optimum"
            packHTML(63).HTMLIDIOTHTES(5).Eltrans = "βέλτιστος"
            packHTML(63).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει ποια τιμή είναι η βέλτιστη τιμή για το μετρητή"
            packHTML(63).HTMLIDIOTHTES(5).syndesmos = ""

            packHTML(63).HTMLIDIOTHTES(6).idiothta = "value"
            packHTML(63).HTMLIDIOTHTES(6).Eltrans = "αξία"
            packHTML(63).HTMLIDIOTHTES(6).Perigrafh = "Απαιτείται. Καθορίζει την τρέχουσα τιμή του μετρητή"
            packHTML(63).HTMLIDIOTHTES(6).syndesmos = ""

            packHTML(63).HTMLIDIOTHTES(0).values(0).onoma = "(form_id)"
            packHTML(63).HTMLIDIOTHTES(0).values(0).ellinika = "(form_id)"
            packHTML(63).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει το στοιχείο φόρμας στο οποίο ανήκει το στοιχείο <meter>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο."

            packHTML(63).HTMLIDIOTHTES(1).values(0).onoma = "(number)"
            packHTML(63).HTMLIDIOTHTES(1).values(0).ellinika = "(number)"
            packHTML(63).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει έναν αριθμό κινητής υποδιαστολής που θεωρείται υψηλή τιμή"

            packHTML(63).HTMLIDIOTHTES(2).values(0).onoma = "(number)"
            packHTML(63).HTMLIDIOTHTES(2).values(0).ellinika = "(number)"
            packHTML(63).HTMLIDIOTHTES(2).values(0).perigrafh = ""

            packHTML(63).HTMLIDIOTHTES(3).values(0).onoma = "(number)"
            packHTML(63).HTMLIDIOTHTES(3).values(0).ellinika = "(number)"
            packHTML(63).HTMLIDIOTHTES(3).values(0).perigrafh = ""

            packHTML(63).HTMLIDIOTHTES(4).values(0).onoma = "(number)"
            packHTML(63).HTMLIDIOTHTES(4).values(0).ellinika = "(number)"
            packHTML(63).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει έναν αριθμό κινητής υποδιαστολής που θεωρείται χαμηλή τιμή"

            packHTML(63).HTMLIDIOTHTES(5).values(0).onoma = "(number)"
            packHTML(63).HTMLIDIOTHTES(5).values(0).ellinika = "(number)"
            packHTML(63).HTMLIDIOTHTES(5).values(0).perigrafh = "Καθορίζει έναν αριθμό κινητής υποδιαστολής που είναι η βέλτιστη τιμή του μετρητή"

            packHTML(63).HTMLIDIOTHTES(6).values(0).onoma = "(number)"
            packHTML(63).HTMLIDIOTHTES(6).values(0).ellinika = "(number)"
            packHTML(63).HTMLIDIOTHTES(6).values(0).perigrafh = "Απαιτείται. Καθορίζει έναν αριθμό κινητής υποδιαστολής που είναι η τρέχουσα τιμή του μετρητή"
#End Region
#Region "nav"
            ReDim packHTML(64).HTMLIDIOTHTES(-1)
            packHTML(64).Etiketa = "<nav>"
            packHTML(64).onomasia = "πλοήγησης"
            packHTML(64).ELtrans = "<πλοήγησης>"
            packHTML(64).Perigrafh = "Η ετικέτα <nav> ορίζει ένα σύνολο συνδέσμων πλοήγησης."
            packHTML(64).Syndesmos = ""
#End Region
#Region "<noscript>"
            ReDim packHTML(65).HTMLIDIOTHTES(-1)
            packHTML(65).Etiketa = "<noscript>"
            packHTML(65).onomasia = "χωριςscript"
            packHTML(65).ELtrans = "<χωριςscript>"
            packHTML(65).Perigrafh = "Η ετικέτα <noscript> ορίζει ένα εναλλακτικό περιεχόμενο που θα εμφανίζεται σε χρήστες που έχουν απενεργοποιήσει σενάρια στο πρόγραμμα περιήγησής τους ή έχουν πρόγραμμα περιήγησης που δεν υποστηρίζει σενάρια."
            packHTML(65).Syndesmos = ""
#End Region
#Region "<object>"
            ReDim packHTML(66).HTMLIDIOTHTES(7)
            ReDim packHTML(66).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(66).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(66).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(66).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(66).HTMLIDIOTHTES(4).values(0)
            ReDim packHTML(66).HTMLIDIOTHTES(5).values(1)
            ReDim packHTML(66).HTMLIDIOTHTES(6).values(0)
            ReDim packHTML(66).HTMLIDIOTHTES(7).values(0)
            packHTML(66).Etiketa = "<object>"
            packHTML(66).onomasia = "αντικείμενο"
            packHTML(66).ELtrans = "<αντικείμενο>"
            packHTML(66).Perigrafh = "Η ετικέτα <object> σχεδιάστηκε αρχικά για την ενσωμάτωση των προσθηκών του προγράμματος περιήγησης."
            packHTML(66).Syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(0).idiothta = "data"
            packHTML(66).HTMLIDIOTHTES(0).Eltrans = "δεδομένα"
            packHTML(66).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τη διεύθυνση URL του πόρου που θα χρησιμοποιηθεί από το αντικείμενο"
            packHTML(66).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(1).idiothta = "form"
            packHTML(66).HTMLIDIOTHTES(1).Eltrans = "φόρμα"
            packHTML(66).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει σε ποια μορφή ανήκει το αντικείμενο"
            packHTML(66).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(2).idiothta = "height"
            packHTML(66).HTMLIDIOTHTES(2).Eltrans = "ύψος"
            packHTML(66).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει το ύψος του αντικειμένου"
            packHTML(66).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(3).idiothta = "name"
            packHTML(66).HTMLIDIOTHTES(3).Eltrans = "όνομα"
            packHTML(66).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει ένα όνομα για το αντικείμενο"
            packHTML(66).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(4).idiothta = "type"
            packHTML(66).HTMLIDIOTHTES(4).Eltrans = "τύπος"
            packHTML(66).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει τον τύπο δεδομένων μέσου που καθορίζεται στο χαρακτηριστικό data"
            packHTML(66).HTMLIDIOTHTES(4).syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(5).idiothta = "typemustmatch"
            packHTML(66).HTMLIDIOTHTES(5).Eltrans = "τύπος-ταιριάζει"
            packHTML(66).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει εάν το χαρακτηριστικό type και το πραγματικό περιεχόμενο του πόρου πρέπει να ταιριάζουν για να εμφανίζεται"
            packHTML(66).HTMLIDIOTHTES(5).syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(6).idiothta = "usemap"
            packHTML(66).HTMLIDIOTHTES(6).Eltrans = "χάρτη-χρήσης"
            packHTML(66).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει το όνομα ενός χάρτη εικόνας από την πλευρά του πελάτη που θα χρησιμοποιηθεί με το αντικείμενο"
            packHTML(66).HTMLIDIOTHTES(6).syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(7).idiothta = "width"
            packHTML(66).HTMLIDIOTHTES(7).Eltrans = "πλάτος"
            packHTML(66).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει το πλάτος του αντικειμένου"
            packHTML(66).HTMLIDIOTHTES(7).syndesmos = ""

            packHTML(66).HTMLIDIOTHTES(0).values(0).onoma = "(URL)"
            packHTML(66).HTMLIDIOTHTES(0).values(0).ellinika = "(URL)"
            packHTML(66).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL του πόρου που θα χρησιμοποιηθεί από το αντικείμενο. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε δεδομένα σε άλλο ιστότοπο (όπως href='http://www.example.com/images/pic_trulli.jpg') Μια σχετική διεύθυνση URL - οδηγεί σε δεδομένα σε έναν ιστότοπο (όπως href='pic_trulli.jpg')"

            packHTML(66).HTMLIDIOTHTES(1).values(0).onoma = "(form_id)"
            packHTML(66).HTMLIDIOTHTES(1).values(0).ellinika = "(form_id)"
            packHTML(66).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει το στοιχείο <form> στο οποίο ανήκει το στοιχείο <object>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο."

            packHTML(66).HTMLIDIOTHTES(2).values(0).onoma = "(pixels)"
            packHTML(66).HTMLIDIOTHTES(2).values(0).ellinika = "(pixels)"
            packHTML(66).HTMLIDIOTHTES(2).values(0).perigrafh = "Το ύψος του αντικειμένου, σε pixel (δηλαδή ύψος = '100')"

            packHTML(66).HTMLIDIOTHTES(3).values(0).onoma = "(name)"
            packHTML(66).HTMLIDIOTHTES(3).values(0).ellinika = "(name)"
            packHTML(66).HTMLIDIOTHTES(3).values(0).perigrafh = "Το όνομα του στοιχείου <object>"

            packHTML(66).HTMLIDIOTHTES(4).values(0).onoma = "true"
            packHTML(66).HTMLIDIOTHTES(4).values(0).ellinika = "αληθής"
            packHTML(66).HTMLIDIOTHTES(4).values(0).perigrafh = ""

            packHTML(66).HTMLIDIOTHTES(4).values(0).onoma = "false"
            packHTML(66).HTMLIDIOTHTES(4).values(0).ellinika = "ψευδής"
            packHTML(66).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει εάν το χαρακτηριστικό type και το πραγματικό περιεχόμενο του πόρου πρέπει να ταιριάζουν για να εμφανίζεται"

            packHTML(66).HTMLIDIOTHTES(5).values(0).onoma = "(#mapname)"
            packHTML(66).HTMLIDIOTHTES(5).values(0).ellinika = "(#mapname)"
            packHTML(66).HTMLIDIOTHTES(5).values(0).perigrafh = "Ένας χαρακτήρας κατακερματισμού (#) συν το όνομα του στοιχείου χάρτη που θα χρησιμοποιηθεί"

            packHTML(66).HTMLIDIOTHTES(6).values(0).onoma = "(pixels)"
            packHTML(66).HTMLIDIOTHTES(6).values(0).ellinika = "(pixels)"
            packHTML(66).HTMLIDIOTHTES(6).values(0).perigrafh = "Το πλάτος του αντικειμένου, σε pixel (δηλαδή πλάτος = '100')"

#End Region
#Region "<ol>"
            ReDim packHTML(67).HTMLIDIOTHTES(2)
            ReDim packHTML(67).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(67).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(67).HTMLIDIOTHTES(2).values(4)
            packHTML(67).Etiketa = "<ol>"
            packHTML(67).onomasia = "ταξινομημένη-λίστα"
            packHTML(67).ELtrans = "<ταξινομημένη-λίστα>"
            packHTML(67).Perigrafh = "Η ετικέτα <ol> ορίζει μια ταξινομημένη λίστα. Μια ταξινομημένη λίστα μπορεί να είναι αριθμητική ή αλφαβητική."
            packHTML(67).Syndesmos = ""

            packHTML(67).HTMLIDIOTHTES(0).idiothta = "reversed"
            packHTML(67).HTMLIDIOTHTES(0).Eltrans = "αντίστροφα"
            packHTML(67).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι η σειρά της λίστας πρέπει να αντιστραφεί (9,8,7...)"
            packHTML(67).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(67).HTMLIDIOTHTES(1).idiothta = "start"
            packHTML(67).HTMLIDIOTHTES(1).Eltrans = "αρχή"
            packHTML(67).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει την τιμή έναρξης μιας ταξινομημένης λίστας"
            packHTML(67).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(67).HTMLIDIOTHTES(2).idiothta = "type"
            packHTML(67).HTMLIDIOTHTES(2).Eltrans = "τύπος"
            packHTML(67).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει το είδος του δείκτη που θα χρησιμοποιηθεί στη λίστα"
            packHTML(67).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(67).HTMLIDIOTHTES(1).values(0).onoma = "(number)"
            packHTML(67).HTMLIDIOTHTES(1).values(0).ellinika = "(number)"
            packHTML(67).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει την τιμή έναρξης του πρώτου στοιχείου λίστας στη λίστα με την παραγγελία"

            packHTML(67).HTMLIDIOTHTES(2).values(0).onoma = "1"
            packHTML(67).HTMLIDIOTHTES(2).values(0).ellinika = "1"
            packHTML(67).HTMLIDIOTHTES(2).values(0).perigrafh = "Προκαθορισμένο. Δεκαδικοί αριθμοί (1, 2, 3, 4)"

            packHTML(67).HTMLIDIOTHTES(2).values(1).onoma = "a"
            packHTML(67).HTMLIDIOTHTES(2).values(1).ellinika = "a"
            packHTML(67).HTMLIDIOTHTES(2).values(1).perigrafh = "Αλφαβητικά ταξινομημένη λίστα, πεζά (a, b, c, d)"

            packHTML(67).HTMLIDIOTHTES(2).values(2).onoma = "A"
            packHTML(67).HTMLIDIOTHTES(2).values(2).ellinika = "A"
            packHTML(67).HTMLIDIOTHTES(2).values(2).perigrafh = "Αλφαβητικά ταξινομημένη λίστα, κεφαλαία (A, B, C, D)"

            packHTML(67).HTMLIDIOTHTES(2).values(3).onoma = "i"
            packHTML(67).HTMLIDIOTHTES(2).values(3).ellinika = "i"
            packHTML(67).HTMLIDIOTHTES(2).values(3).perigrafh = "Ρωμαϊκοί αριθμοί, πεζοί (i, ii, iii, iv)"

            packHTML(67).HTMLIDIOTHTES(2).values(4).onoma = "I"
            packHTML(67).HTMLIDIOTHTES(2).values(4).ellinika = "I"
            packHTML(67).HTMLIDIOTHTES(2).values(4).perigrafh = "Ρωμαϊκοί αριθμοί, κεφαλαίοι (I, II, III, IV)"


#End Region
#Region "<optgroup>"
            ReDim packHTML(68).HTMLIDIOTHTES(1)
            ReDim packHTML(68).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(68).HTMLIDIOTHTES(1).values(0)
            packHTML(68).Etiketa = "<optgroup>"
            packHTML(68).onomasia = "αναπτυσσόμενη-λίστα"
            packHTML(68).ELtrans = "<αναπτυσσόμενη-λίστα>"
            packHTML(68).Perigrafh = "Η ετικέτα <optgroup> χρησιμοποιείται για την ομαδοποίηση σχετικών επιλογών σε ένα στοιχείο <επιλογή> (αναπτυσσόμενη λίστα)."
            packHTML(68).Syndesmos = ""

            packHTML(68).HTMLIDIOTHTES(0).idiothta = "disabled"
            packHTML(68).HTMLIDIOTHTES(0).Eltrans = "απενεργοποιημένη"
            packHTML(68).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι μια ομάδα επιλογών πρέπει να είναι απενεργοποιημένη"
            packHTML(68).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(68).HTMLIDIOTHTES(1).idiothta = "label"
            packHTML(68).HTMLIDIOTHTES(1).Eltrans = "ετικέτα"
            packHTML(68).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει μια ετικέτα για μια ομάδα επιλογών"
            packHTML(68).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(68).HTMLIDIOTHTES(1).values(0).onoma = "(text)"
            packHTML(68).HTMLIDIOTHTES(1).values(0).ellinika = "(text)"
            packHTML(68).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει μια ετικέτα/περιγραφή για την ομάδα επιλογών"
#End Region
#Region "<option>"
            ReDim packHTML(69).HTMLIDIOTHTES(3)
            ReDim packHTML(69).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(69).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(69).HTMLIDIOTHTES(2).values(-1)
            ReDim packHTML(69).HTMLIDIOTHTES(3).values(0)
            packHTML(69).Etiketa = "<option>"
            packHTML(69).onomasia = "λίστα επιλογής"
            packHTML(69).ELtrans = "<λίστα-επιλογής>"
            packHTML(69).Perigrafh = "Η ετικέτα <option> ορίζει μια επιλογή σε μια λίστα επιλογής."
            packHTML(69).Syndesmos = ""

            packHTML(69).HTMLIDIOTHTES(0).idiothta = "disabled"
            packHTML(69).HTMLIDIOTHTES(0).Eltrans = "απενεργοποιημένη"
            packHTML(69).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι μια επιλογή πρέπει να είναι απενεργοποιημένη"
            packHTML(69).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(69).HTMLIDIOTHTES(1).idiothta = "label"
            packHTML(69).HTMLIDIOTHTES(1).Eltrans = "ετικέτα"
            packHTML(69).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει μια μικρότερη ετικέτα για μια επιλογή"
            packHTML(69).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(69).HTMLIDIOTHTES(2).idiothta = "selected"
            packHTML(69).HTMLIDIOTHTES(2).Eltrans = "επιλεγμένο"
            packHTML(69).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει ότι μια επιλογή θα πρέπει να προεπιλέγεται κατά τη φόρτωση της σελίδας"
            packHTML(69).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(69).HTMLIDIOTHTES(3).idiothta = "value"
            packHTML(69).HTMLIDIOTHTES(3).Eltrans = "αξία"
            packHTML(69).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει την τιμή που θα σταλεί σε έναν διακομιστή"
            packHTML(69).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(69).HTMLIDIOTHTES(1).values(0).onoma = "(text)"
            packHTML(69).HTMLIDIOTHTES(1).values(0).ellinika = "(text)"
            packHTML(69).HTMLIDIOTHTES(1).values(0).perigrafh = "Μια συντομότερη έκδοση για την επιλογή"

            packHTML(69).HTMLIDIOTHTES(3).values(0).onoma = "(text)"
            packHTML(69).HTMLIDIOTHTES(3).values(0).ellinika = "(text)"
            packHTML(69).HTMLIDIOTHTES(3).values(0).perigrafh = "Η τιμή που θα σταλεί στον διακομιστή"
#End Region
#Region "<output>"
            ReDim packHTML(70).HTMLIDIOTHTES(2)
            ReDim packHTML(70).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(70).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(70).HTMLIDIOTHTES(2).values(0)

            packHTML(70).Etiketa = "<output>"
            packHTML(70).onomasia = "παραγωγή"
            packHTML(70).ELtrans = "<παραγωγή>"
            packHTML(70).Perigrafh = "Η ετικέτα <output> χρησιμοποιείται για να αναπαραστήσει το αποτέλεσμα ενός υπολογισμού (όπως αυτός που εκτελείται από ένα σενάριο)."
            packHTML(70).Syndesmos = ""

            packHTML(70).HTMLIDIOTHTES(0).idiothta = "for"
            packHTML(70).HTMLIDIOTHTES(0).Eltrans = "Για"
            packHTML(70).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τη σχέση μεταξύ του αποτελέσματος του υπολογισμού και των στοιχείων που χρησιμοποιούνται στον υπολογισμό"
            packHTML(70).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(70).HTMLIDIOTHTES(1).idiothta = "form"
            packHTML(70).HTMLIDIOTHTES(1).Eltrans = "φόρμα"
            packHTML(70).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει σε ποια μορφή ανήκει το στοιχείο εξόδου"
            packHTML(70).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(70).HTMLIDIOTHTES(2).idiothta = "name"
            packHTML(70).HTMLIDIOTHTES(2).Eltrans = "όνομα"
            packHTML(70).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει ένα όνομα για το στοιχείο εξόδου"
            packHTML(70).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(70).HTMLIDIOTHTES(0).values(0).onoma = "(element_id)"
            packHTML(70).HTMLIDIOTHTES(0).values(0).ellinika = "(element_id)"
            packHTML(70).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει μια λίστα αναγνωριστικών ενός ή περισσότερων στοιχείων διαχωρισμένων με κενό χώρο που καθορίζει τη σχέση μεταξύ του αποτελέσματος του υπολογισμού και των στοιχείων που χρησιμοποιούνται στον υπολογισμό"

            packHTML(70).HTMLIDIOTHTES(1).values(0).onoma = "(form_id)"
            packHTML(70).HTMLIDIOTHTES(1).values(0).ellinika = "(form_id)"
            packHTML(70).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει το στοιχείο φόρμας στο οποίο ανήκει το στοιχείο <output>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο."

            packHTML(70).HTMLIDIOTHTES(2).values(0).onoma = "(name)"
            packHTML(70).HTMLIDIOTHTES(2).values(0).ellinika = "(name)"
            packHTML(70).HTMLIDIOTHTES(2).values(0).perigrafh = "Specifies the name of the <output> element"

#End Region
#Region "<p>"
            ReDim packHTML(71).HTMLIDIOTHTES(-1)
            packHTML(71).Etiketa = "<p>"
            packHTML(71).onomasia = "παράγραφο"
            packHTML(71).ELtrans = "<παράγραφο>"
            packHTML(71).Perigrafh = "Η ετικέτα <p> ορίζει μια παράγραφο."
            packHTML(71).Syndesmos = ""
#End Region
#Region "<param>"
            ReDim packHTML(72).HTMLIDIOTHTES(1)
            ReDim packHTML(72).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(72).HTMLIDIOTHTES(1).values(0)
            packHTML(72).Etiketa = "<param>"
            packHTML(72).onomasia = "παραμέτρων "
            packHTML(72).ELtrans = "<παραμέτρων >"
            packHTML(72).Perigrafh = "Η ετικέτα <param> χρησιμοποιείται για τον καθορισμό παραμέτρων για ένα στοιχείο <object>."
            packHTML(72).Syndesmos = ""

            packHTML(72).HTMLIDIOTHTES(0).idiothta = "name"
            packHTML(72).HTMLIDIOTHTES(0).Eltrans = "όνομα"
            packHTML(72).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει το όνομα μιας παραμέτρου"
            packHTML(72).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(72).HTMLIDIOTHTES(1).idiothta = "value"
            packHTML(72).HTMLIDIOTHTES(1).Eltrans = "αξίααξία"
            packHTML(72).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει την τιμή της παραμέτρου"
            packHTML(72).HTMLIDIOTHTES(1).syndesmos = ""


            packHTML(72).HTMLIDIOTHTES(0).values(0).onoma = "(name)"
            packHTML(72).HTMLIDIOTHTES(0).values(0).ellinika = "(name)"
            packHTML(72).HTMLIDIOTHTES(0).values(0).perigrafh = "Το όνομα της παραμέτρου"

            packHTML(72).HTMLIDIOTHTES(1).values(0).onoma = "(value)"
            packHTML(72).HTMLIDIOTHTES(1).values(0).ellinika = "(value)"
            packHTML(72).HTMLIDIOTHTES(1).values(0).perigrafh = "Η τιμή της παραμέτρου"
#End Region
#Region "<picture>"
            ReDim packHTML(73).HTMLIDIOTHTES(-1)
            packHTML(73).Etiketa = "<picture>"
            packHTML(73).onomasia = "εικόνα "
            packHTML(73).ELtrans = "<εικόνα>"
            packHTML(73).Perigrafh = "Η ετικέτα <picture> δίνει στους προγραμματιστές ιστού μεγαλύτερη ευελιξία στον καθορισμό πόρων εικόνας."
            packHTML(73).Syndesmos = ""
#End Region
#Region "<pre>"
            ReDim packHTML(74).HTMLIDIOTHTES(-1)
            packHTML(74).Etiketa = "<pre>"
            packHTML(74).onomasia = "προδιαμορφωμένο "
            packHTML(74).ELtrans = "<προδιαμορφωμένο>"
            packHTML(74).Perigrafh = "Η ετικέτα <pre> ορίζει προδιαμορφωμένο κείμενο."
            packHTML(74).Syndesmos = ""
#End Region
#Region "<progress>"
            ReDim packHTML(75).HTMLIDIOTHTES(1)
            ReDim packHTML(75).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(75).HTMLIDIOTHTES(1).values(0)

            packHTML(75).Etiketa = "<progress>"
            packHTML(75).onomasia = "εξέλιξη "
            packHTML(75).ELtrans = "<εξέλιξη>"
            packHTML(75).Perigrafh = "Η ετικέτα <pre> ορίζει προδιαμορφωμένο κείμενο."
            packHTML(75).Syndesmos = ""

            packHTML(75).HTMLIDIOTHTES(0).idiothta = "max"
            packHTML(75).HTMLIDIOTHTES(0).Eltrans = "Μέγιστη"
            packHTML(75).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει πόση δουλειά απαιτεί συνολικά η εργασία. Η προεπιλεγμένη τιμή είναι 1"
            packHTML(75).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(75).HTMLIDIOTHTES(1).idiothta = "value"
            packHTML(75).HTMLIDIOTHTES(1).Eltrans = "αξία"
            packHTML(75).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει πόσο από την εργασία έχει ολοκληρωθεί"
            packHTML(75).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(75).HTMLIDIOTHTES(0).values(0).onoma = "(number)"
            packHTML(75).HTMLIDIOTHTES(0).values(0).ellinika = "(number)"
            packHTML(75).HTMLIDIOTHTES(0).values(0).perigrafh = "Ένας αριθμός κινητής υποδιαστολής που καθορίζει πόση εργασία απαιτεί συνολικά η εργασία για να θεωρηθεί ολοκληρωμένη. Η προεπιλεγμένη τιμή είναι 1."

            packHTML(75).HTMLIDIOTHTES(1).values(0).onoma = "(number)"
            packHTML(75).HTMLIDIOTHTES(1).values(0).ellinika = "(number)"
            packHTML(75).HTMLIDIOTHTES(1).values(0).perigrafh = "Ένας αριθμός κινητής υποδιαστολής που προσδιορίζει πόσο από την εργασία έχει ολοκληρωθεί"
#End Region
#Region "<q>"
            ReDim packHTML(76).HTMLIDIOTHTES(0)
            ReDim packHTML(76).HTMLIDIOTHTES(0).values(0)
            packHTML(76).Etiketa = "<pre>"
            packHTML(76).onomasia = "σύντομη "
            packHTML(76).ELtrans = "<σύντομη>"
            packHTML(76).Perigrafh = "Η ετικέτα <q> ορίζει μια σύντομη προσφορά"
            packHTML(76).Syndesmos = ""

            packHTML(76).HTMLIDIOTHTES(0).idiothta = "cite"
            packHTML(76).HTMLIDIOTHTES(0).Eltrans = "αναφορά"
            packHTML(76).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τη διεύθυνση URL πηγής της προσφοράς"
            packHTML(76).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(76).HTMLIDIOTHTES(0).values(0).onoma = "(URL)"
            packHTML(76).HTMLIDIOTHTES(0).values(0).ellinika = "(URL)"
            packHTML(76).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL πηγής της προσφοράς. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως href='http://www.example.com/page.htm') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο μέσα σε έναν ιστότοπο (όπως href='page.htm')"

#End Region
#Region "<rp>"
            ReDim packHTML(77).HTMLIDIOTHTES(-1)
            packHTML(77).Etiketa = "<rp>"
            packHTML(77).onomasia = "παρενθέσεων "
            packHTML(77).ELtrans = "<παρενθέσεων>"
            packHTML(77).Perigrafh = "Η ετικέτα <rp> μπορεί να χρησιμοποιηθεί για την παροχή παρενθέσεων γύρω από ένα κείμενο ρουμπίνι, που θα εμφανίζεται από προγράμματα περιήγησης που δεν υποστηρίζουν σχολιασμούς ρουμπίνι."
            packHTML(77).Syndesmos = ""
#End Region
#Region "<rt>"
            ReDim packHTML(77).HTMLIDIOTHTES(-1)
            packHTML(77).Etiketa = "<rt>"
            packHTML(77).onomasia = "τυπογραφία-Ασίας"
            packHTML(77).ELtrans = "<τυπογραφία-Ασίας>"
            packHTML(77).Perigrafh = "Η ετικέτα <rt> ορίζει μια επεξήγηση ή προφορά χαρακτήρων (για την τυπογραφία της Ανατολικής Ασίας) σε ένα ρουμπινί σχολιασμό."
            packHTML(77).Syndesmos = ""
#End Region
#Region "<ruby>"
            ReDim packHTML(78).HTMLIDIOTHTES(-1)
            packHTML(78).Etiketa = "<ruby>"
            packHTML(78).onomasia = "ρουμπίνι"
            packHTML(78).ELtrans = "<ρουμπίνι>"
            packHTML(78).Perigrafh = "Η ετικέτα <ruby> καθορίζει έναν σχολιασμό ρουμπίνι."
            packHTML(78).Syndesmos = ""
#End Region
#Region "<s>"
            ReDim packHTML(79).HTMLIDIOTHTES(-1)
            packHTML(79).Etiketa = "<s>"
            packHTML(79).onomasia = "υπογράμηση-μέση"
            packHTML(79).ELtrans = "<υπογράμηση-μέση>"
            packHTML(79).Perigrafh = "Ορίζει κείμενο που δεν είναι πλέον σωστό"
            packHTML(79).Syndesmos = ""
#End Region
#Region "<samp>"
            ReDim packHTML(80).HTMLIDIOTHTES(-1)
            packHTML(80).Etiketa = "<samp>"
            packHTML(80).onomasia = "δείγμα-εξόδου"
            packHTML(80).ELtrans = "<δείγμα-εξόδου>"
            packHTML(80).Perigrafh = "Καθορίζει το δείγμα εξόδου από ένα πρόγραμμα υπολογιστή"
            packHTML(80).Syndesmos = ""
#End Region
#Region "<script>"
            ReDim packHTML(81).HTMLIDIOTHTES(7)
            ReDim packHTML(81).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(81).HTMLIDIOTHTES(1).values(1)
            ReDim packHTML(81).HTMLIDIOTHTES(2).values(-1)
            ReDim packHTML(81).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(81).HTMLIDIOTHTES(4).values(1)
            ReDim packHTML(81).HTMLIDIOTHTES(5).values(7)
            ReDim packHTML(81).HTMLIDIOTHTES(6).values(0)
            ReDim packHTML(81).HTMLIDIOTHTES(7).values(0)
            packHTML(81).Etiketa = "<script>"
            packHTML(81).onomasia = "script"
            packHTML(81).ELtrans = "<script>"
            packHTML(81).Perigrafh = "Καθορίζει το δείγμα εξόδου από ένα πρόγραμμα υπολογιστή"
            packHTML(81).Syndesmos = ""

            packHTML(81).HTMLIDIOTHTES(0).idiothta = "async"
            packHTML(81).HTMLIDIOTHTES(0).Eltrans = "ασυγχρονισμός"
            packHTML(81).HTMLIDIOTHTES(0).Perigrafh = ""
            packHTML(81).HTMLIDIOTHTES(0).syndesmos = "Καθορίζει ότι η λήψη του σεναρίου γίνεται παράλληλα με την ανάλυση της σελίδας και εκτελείται μόλις είναι διαθέσιμο (πριν ολοκληρωθεί η ανάλυση) (μόνο για εξωτερικά σενάρια)"

            packHTML(81).HTMLIDIOTHTES(1).idiothta = "crossorigin"
            packHTML(81).HTMLIDIOTHTES(1).Eltrans = "διασταυρούμενη-καταγωγή"
            packHTML(81).HTMLIDIOTHTES(1).Perigrafh = "Ορίζει τη λειτουργία του αιτήματος σε ένα αίτημα HTTP CORS"
            packHTML(81).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(81).HTMLIDIOTHTES(2).idiothta = "defer"
            packHTML(81).HTMLIDIOTHTES(2).Eltrans = "αναβάλλω"
            packHTML(81).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει ότι η λήψη του σεναρίου γίνεται παράλληλα με την ανάλυση της σελίδας και εκτελείται αφού ολοκληρωθεί η ανάλυση της σελίδας (μόνο για εξωτερικά σενάρια)"
            packHTML(81).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(81).HTMLIDIOTHTES(3).idiothta = "integrity"
            packHTML(81).HTMLIDIOTHTES(3).Eltrans = "ακεραιότητα"
            packHTML(81).HTMLIDIOTHTES(3).Perigrafh = "Επιτρέπει σε ένα πρόγραμμα περιήγησης να ελέγχει το σενάριο που έχει ληφθεί για να διασφαλίσει ότι ο κώδικας δεν θα φορτωθεί ποτέ εάν η πηγή έχει υποστεί χειραγώγηση"
            packHTML(81).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(81).HTMLIDIOTHTES(4).idiothta = "nomodule"
            packHTML(81).HTMLIDIOTHTES(4).Eltrans = "νομοστοιχείο"
            packHTML(81).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει ότι το σενάριο δεν πρέπει να εκτελείται σε προγράμματα περιήγησης που υποστηρίζουν μονάδες ES2015"
            packHTML(81).HTMLIDIOTHTES(4).syndesmos = ""

            packHTML(81).HTMLIDIOTHTES(5).idiothta = "referrerpolicy"
            packHTML(81).HTMLIDIOTHTES(5).Eltrans = "πολιτική-παραπομπής"
            packHTML(81).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει ποιες πληροφορίες παραπομπής θα αποστέλλονται κατά την ανάκτηση ενός σεναρίου"
            packHTML(81).HTMLIDIOTHTES(5).syndesmos = ""

            packHTML(81).HTMLIDIOTHTES(6).idiothta = "src"
            packHTML(81).HTMLIDIOTHTES(6).Eltrans = "διεύθυνση"
            packHTML(81).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει τη διεύθυνση URL ενός εξωτερικού αρχείου σεναρίου"
            packHTML(81).HTMLIDIOTHTES(6).syndesmos = ""

            packHTML(81).HTMLIDIOTHTES(7).idiothta = "type"
            packHTML(81).HTMLIDIOTHTES(7).Eltrans = "τύπος"
            packHTML(81).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει τον τύπο μέσου του σεναρίου"
            packHTML(81).HTMLIDIOTHTES(7).syndesmos = ""

            packHTML(81).HTMLIDIOTHTES(1).values(0).onoma = "anonymous"
            packHTML(81).HTMLIDIOTHTES(1).values(0).ellinika = "Ανώνυμος"
            packHTML(81).HTMLIDIOTHTES(1).values(0).perigrafh = "ανώνυμη - Εκτελείται αίτημα διασταυρούμενης προέλευσης. Δεν αποστέλλονται διαπιστευτήρια"

            packHTML(81).HTMLIDIOTHTES(1).values(1).onoma = "use-credentials"
            packHTML(81).HTMLIDIOTHTES(1).values(1).ellinika = "χρήση-διαπιστευτήρια"
            packHTML(81).HTMLIDIOTHTES(1).values(1).perigrafh = "use-credentials - Εκτελείται αίτημα διασταυρούμενης προέλευσης. Τα διαπιστευτήρια αποστέλλονται (π.χ. ένα cookie, ένα πιστοποιητικό, ένας βασικός έλεγχος ταυτότητας HTTP)"

            packHTML(81).HTMLIDIOTHTES(3).values(0).onoma = "(filehash)"
            packHTML(81).HTMLIDIOTHTES(3).values(0).ellinika = "(filehash)"
            packHTML(81).HTMLIDIOTHTES(3).values(0).perigrafh = "Η τιμή κατακερματισμού του αρχείου του εξωτερικού αρχείου σεναρίου"

            packHTML(81).HTMLIDIOTHTES(4).values(0).onoma = "True"
            packHTML(81).HTMLIDIOTHTES(4).values(0).ellinika = "Αληθής"
            packHTML(81).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει ότι το σενάριο δεν πρέπει να εκτελείται σε προγράμματα περιήγησης που υποστηρίζουν μονάδες ES2015"

            packHTML(81).HTMLIDIOTHTES(4).values(1).onoma = "False"
            packHTML(81).HTMLIDIOTHTES(4).values(1).ellinika = "Ψευδής"
            packHTML(81).HTMLIDIOTHTES(4).values(1).perigrafh = "Καθορίζει ότι το σενάριο δεν πρέπει να εκτελείται σε προγράμματα περιήγησης που υποστηρίζουν μονάδες ES2015"

            packHTML(81).HTMLIDIOTHTES(5).values = packHTML(2).HTMLIDIOTHTES(5).values

            packHTML(81).HTMLIDIOTHTES(6).values(0).onoma = "(URL)"
            packHTML(81).HTMLIDIOTHTES(6).values(0).ellinika = "(URL)"
            packHTML(81).HTMLIDIOTHTES(6).values(0).perigrafh = "Το URL του εξωτερικού αρχείου σεναρίου. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως src='http://www.example.com/example.js') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο σε έναν ιστότοπο (όπως src='/scripts/example.js')"

            packHTML(81).HTMLIDIOTHTES(7).values(0).onoma = "(scripttype)"
            packHTML(81).HTMLIDIOTHTES(7).values(0).ellinika = "(scripttype)"
            packHTML(81).HTMLIDIOTHTES(7).values(0).perigrafh = "Καθορίζει τον τύπο του σεναρίου. Μερικές κοινές αξίες: Ένας τύπος MIME JavaScript όπως: application/javascript (προεπιλογή) ή application/ecmascript μονάδα μέτρησης: Άλλος τύπος MIME. Το χαρακτηριστικό src θα αγνοηθεί Ανατρέξτε στο IANA Media Types για μια πλήρη λίστα με τυπικούς τύπους μέσων."
#End Region
#Region "<section>"
            ReDim packHTML(82).HTMLIDIOTHTES(-1)
            packHTML(82).Etiketa = "<section>"
            packHTML(82).onomasia = "Ενότητα"
            packHTML(82).ELtrans = "<Ενότητα>"
            packHTML(82).Perigrafh = "Η ετικέτα <section> ορίζει μια ενότητα σε ένα έγγραφο."
            packHTML(82).Syndesmos = ""
#End Region
#Region "<select>"
            ReDim packHTML(83).HTMLIDIOTHTES(6)
            ReDim packHTML(83).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(83).HTMLIDIOTHTES(1).values(-1)
            ReDim packHTML(83).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(83).HTMLIDIOTHTES(3).values(-1)
            ReDim packHTML(83).HTMLIDIOTHTES(4).values(0)
            ReDim packHTML(83).HTMLIDIOTHTES(5).values(-1)
            ReDim packHTML(83).HTMLIDIOTHTES(6).values(0)
            packHTML(83).Etiketa = "<select>"
            packHTML(83).onomasia = "επιλογή"
            packHTML(83).ELtrans = "<επιλογή>"
            packHTML(83).Perigrafh = "Το στοιχείο <επιλογή> χρησιμοποιείται για τη δημιουργία μιας αναπτυσσόμενης λίστας."
            packHTML(83).Syndesmos = ""

            packHTML(83).HTMLIDIOTHTES(0).idiothta = "autofocus"
            packHTML(83).HTMLIDIOTHTES(0).Eltrans = "αυτόματη εστίαση"
            packHTML(83).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι η αναπτυσσόμενη λίστα θα πρέπει να εστιάζει αυτόματα κατά τη φόρτωση της σελίδας"
            packHTML(83).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(83).HTMLIDIOTHTES(1).idiothta = "disabled"
            packHTML(83).HTMLIDIOTHTES(1).Eltrans = "απενεργοποιημένη"
            packHTML(83).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει ότι μια αναπτυσσόμενη λίστα πρέπει να είναι απενεργοποιημένη"
            packHTML(83).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(83).HTMLIDIOTHTES(2).idiothta = "form"
            packHTML(83).HTMLIDIOTHTES(2).Eltrans = "φόρμα"
            packHTML(83).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει σε ποια μορφή ανήκει η αναπτυσσόμενη λίστα"
            packHTML(83).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(83).HTMLIDIOTHTES(3).idiothta = "multiple"
            packHTML(83).HTMLIDIOTHTES(3).Eltrans = "πολλαπλούς"
            packHTML(83).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει ότι μπορούν να επιλεγούν πολλές επιλογές ταυτόχρονα"
            packHTML(83).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(83).HTMLIDIOTHTES(4).idiothta = "name"
            packHTML(83).HTMLIDIOTHTES(4).Eltrans = "όνομα"
            packHTML(83).HTMLIDIOTHTES(4).Perigrafh = "Ορίζει ένα όνομα για την αναπτυσσόμενη λίστα"
            packHTML(83).HTMLIDIOTHTES(4).syndesmos = ""

            packHTML(83).HTMLIDIOTHTES(5).idiothta = "required"
            packHTML(83).HTMLIDIOTHTES(5).Eltrans = "απαιτείται"
            packHTML(83).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει ότι ο χρήστης πρέπει να επιλέξει μια τιμή πριν από την υποβολή της φόρμας"
            packHTML(83).HTMLIDIOTHTES(5).syndesmos = ""

            packHTML(83).HTMLIDIOTHTES(6).idiothta = "size"
            packHTML(83).HTMLIDIOTHTES(6).Eltrans = "Μέγεθος"
            packHTML(83).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει τον αριθμό των ορατών επιλογών σε μια αναπτυσσόμενη λίστα"
            packHTML(83).HTMLIDIOTHTES(6).syndesmos = ""

            packHTML(83).HTMLIDIOTHTES(2).values(0).onoma = "(form_id)"
            packHTML(83).HTMLIDIOTHTES(2).values(0).ellinika = "(form_id)"
            packHTML(83).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει το στοιχείο φόρμας στο οποίο ανήκει το στοιχείο <επιλογή>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι ίση με το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο."

            packHTML(83).HTMLIDIOTHTES(4).values(0).onoma = "(text)"
            packHTML(83).HTMLIDIOTHTES(4).values(0).ellinika = "(text)"
            packHTML(83).HTMLIDIOTHTES(4).values(0).perigrafh = "Το όνομα της αναπτυσσόμενης λίστας"

            packHTML(83).HTMLIDIOTHTES(6).values(0).onoma = "(number)"
            packHTML(83).HTMLIDIOTHTES(6).values(0).ellinika = "(number)"
            packHTML(83).HTMLIDIOTHTES(6).values(0).perigrafh = "Ο αριθμός των ορατών επιλογών στην αναπτυσσόμενη λίστα. Η προεπιλεγμένη τιμή είναι 1. Εάν υπάρχει το χαρακτηριστικό πολλαπλών, η προεπιλεγμένη τιμή είναι 4"

#End Region
#Region "<small>"
            ReDim packHTML(84).HTMLIDIOTHTES(-1)
            packHTML(84).Etiketa = "<small>"
            packHTML(84).onomasia = "μικρό"
            packHTML(84).ELtrans = "<μικρό>"
            packHTML(84).Perigrafh = "Ορίζει μικρότερο κείμενο"
            packHTML(84).Syndesmos = ""
#End Region
#Region "<source>"
            ReDim packHTML(85).HTMLIDIOTHTES(4)
            ReDim packHTML(85).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(85).HTMLIDIOTHTES(1).values(-1)
            ReDim packHTML(85).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(85).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(85).HTMLIDIOTHTES(4).values(0)
            packHTML(85).Etiketa = "<source>"
            packHTML(85).onomasia = "πηγή"
            packHTML(85).ELtrans = "<πηγή>"
            packHTML(85).Perigrafh = "Καθορίζει πολλούς πόρους πολυμέσων για στοιχεία πολυμέσων (<video> και <audio>)"
            packHTML(85).Syndesmos = ""

            packHTML(85).HTMLIDIOTHTES(0).idiothta = "media"
            packHTML(85).HTMLIDIOTHTES(0).Eltrans = "ΜΑΖΙΚΗΣ-ΕΝΗΜΕΡΩΣΗΣ"
            packHTML(85).HTMLIDIOTHTES(0).Perigrafh = "Αποδέχεται οποιοδήποτε έγκυρο ερώτημα μέσων που κανονικά θα καθοριζόταν σε ένα CSS"
            packHTML(85).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(85).HTMLIDIOTHTES(1).idiothta = "sizes"
            packHTML(85).HTMLIDIOTHTES(1).Eltrans = "μεγέθη"
            packHTML(85).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει μεγέθη εικόνας για διαφορετικές διατάξεις σελίδας"
            packHTML(85).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(85).HTMLIDIOTHTES(2).idiothta = "src"
            packHTML(85).HTMLIDIOTHTES(2).Eltrans = "διεύθυνση"
            packHTML(85).HTMLIDIOTHTES(2).Perigrafh = "Απαιτείται όταν το <source> χρησιμοποιείται στο <audio> και <video>. Καθορίζει τη διεύθυνση URL του αρχείου πολυμέσων"
            packHTML(85).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(85).HTMLIDIOTHTES(3).idiothta = "srcset"
            packHTML(85).HTMLIDIOTHTES(3).Eltrans = "διαφορετικές-διεύθυνση"
            packHTML(85).HTMLIDIOTHTES(3).Perigrafh = "Απαιτείται όταν η <πηγή> χρησιμοποιείται στην <εικόνα>. Καθορίζει τη διεύθυνση URL της εικόνας που θα χρησιμοποιηθεί σε διαφορετικές καταστάσεις"
            packHTML(85).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(85).HTMLIDIOTHTES(4).idiothta = "type"
            packHTML(85).HTMLIDIOTHTES(4).Eltrans = "τύπος"
            packHTML(85).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει τον τύπο MIME του πόρου"
            packHTML(85).HTMLIDIOTHTES(4).syndesmos = ""

            packHTML(85).HTMLIDIOTHTES(0).values = packHTML(2).HTMLIDIOTHTES(3).values

            packHTML(85).HTMLIDIOTHTES(2).values(0).onoma = "(URL)"
            packHTML(85).HTMLIDIOTHTES(2).values(0).ellinika = "(URL)"
            packHTML(85).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL του αρχείου πολυμέσων. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως href='http://www.example.com/horse.ogg') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο σε έναν ιστότοπο (όπως href='horse.ogg')"

            packHTML(85).HTMLIDIOTHTES(3).values(0).onoma = "(URL)"
            packHTML(85).HTMLIDIOTHTES(3).values(0).ellinika = "(URL)"
            packHTML(85).HTMLIDIOTHTES(3).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL της εικόνας. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως href='http://www.example.com/flower.jpg') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο σε έναν ιστότοπο (όπως href='flower.jpg')"

            packHTML(85).HTMLIDIOTHTES(4).values(0).onoma = "(media_type)"
            packHTML(85).HTMLIDIOTHTES(4).values(0).ellinika = "(media_type)"
            packHTML(85).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει τον τύπο πολυμέσων Internet του πόρου πολυμέσων. Κοινοί τύποι μέσων: Για βίντεο: βίντεο/ogg βίντεο/mp4 βίντεο/ιστό Για ήχο: ήχος/ogg ήχου/mpeg"
#End Region
#Region "<span>"
            ReDim packHTML(86).HTMLIDIOTHTES(-1)
            packHTML(86).Etiketa = "<span>"
            packHTML(86).onomasia = "συνδέω"
            packHTML(86).ELtrans = "<συνδέω>"
            packHTML(86).Perigrafh = "Καθορίζει μια ενότητα σε ένα έγγραφοο"
            packHTML(86).Syndesmos = ""
#End Region
#Region "<strong>"
            ReDim packHTML(87).HTMLIDIOTHTES(-1)
            packHTML(87).Etiketa = "<strong>"
            packHTML(87).onomasia = "σημαντικό"
            packHTML(87).ELtrans = "<σημαντικό>"
            packHTML(87).Perigrafh = "Ορίζει σημαντικό κείμενο"
            packHTML(87).Syndesmos = ""
#End Region
#Region "<style>"
            ReDim packHTML(88).HTMLIDIOTHTES(1)
            ReDim packHTML(88).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(88).HTMLIDIOTHTES(1).values(0)
            packHTML(88).Etiketa = "<style>"
            packHTML(88).onomasia = "στυλ"
            packHTML(88).ELtrans = "<στυλ>"
            packHTML(88).Perigrafh = "Ορίζει πληροφορίες στυλ για ένα έγγραφο"
            packHTML(88).Syndesmos = ""

            packHTML(88).HTMLIDIOTHTES(0).idiothta = "media"
            packHTML(88).HTMLIDIOTHTES(0).Eltrans = "ΜΑΖΙΚΗΣ-ΕΝΗΜΕΡΩΣΗΣ"
            packHTML(88).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει για ποια μέσα/συσκευή έχει βελτιστοποιηθεί ο πόρος πολυμέσων"
            packHTML(88).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(88).HTMLIDIOTHTES(1).idiothta = "type"
            packHTML(88).HTMLIDIOTHTES(1).Eltrans = "τύπος"
            packHTML(88).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει τον τύπο μέσου της ετικέτας <style>"
            packHTML(88).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(88).HTMLIDIOTHTES(0).values = packHTML(2).HTMLIDIOTHTES(3).values

            packHTML(88).HTMLIDIOTHTES(1).values(0).onoma = "(media_type)"
            packHTML(88).HTMLIDIOTHTES(1).values(0).ellinika = "(media_type)"
            packHTML(88).HTMLIDIOTHTES(1).values(0).perigrafh = "Ο τύπος μέσων Διαδικτύου του φύλλου στυλ. Προς το παρόν, η μόνη υποστηριζόμενη τιμή είναι 'text/css'. Ανατρέξτε στο IANA Media Types για μια πλήρη λίστα με τυπικούς τύπους μέσων"
#End Region
#Region "<sub>"
            ReDim packHTML(89).HTMLIDIOTHTES(-1)
            packHTML(89).Etiketa = "<sub>"
            packHTML(89).onomasia = "δείκτη"
            packHTML(89).ELtrans = "<δείκτη>"
            packHTML(89).Perigrafh = "Καθορίζει εγγεγραμμένο κείμενο"
            packHTML(89).Syndesmos = ""
#End Region
#Region "<summary>"
            ReDim packHTML(90).HTMLIDIOTHTES(-1)
            packHTML(90).Etiketa = "<summary>"
            packHTML(90).onomasia = "περίληψη"
            packHTML(90).ELtrans = "<περίληψη>"
            packHTML(90).Perigrafh = "Καθορίζει εγγεγραμμένο κείμενο"
            packHTML(90).Syndesmos = ""
#End Region
#Region "<sup>"
            ReDim packHTML(91).HTMLIDIOTHTES(-1)
            packHTML(91).Etiketa = "<sup>"
            packHTML(91).onomasia = "επιγραφή"
            packHTML(91).ELtrans = "<επιγραφή>"
            packHTML(91).Perigrafh = "Καθορίζει το κείμενο με επιγραφή"
            packHTML(91).Syndesmos = ""
#End Region
#Region "<svg>"
            ReDim packHTML(92).HTMLIDIOTHTES(-1)
            packHTML(92).Etiketa = "<svg>"
            packHTML(92).onomasia = "γραφικά"
            packHTML(92).ELtrans = "<γραφικά>"
            packHTML(92).Perigrafh = "Η ετικέτα <svg> ορίζει ένα κοντέινερ για γραφικά SVG."
            packHTML(92).Syndesmos = ""
#End Region
#Region "<table>"
            ReDim packHTML(93).HTMLIDIOTHTES(-1)
            packHTML(93).Etiketa = "<table>"
            packHTML(93).onomasia = "πίνακα"
            packHTML(93).ELtrans = "<πίνακα>"
            packHTML(93).Perigrafh = "Η ετικέτα <table> ορίζει έναν πίνακα HTML."
            packHTML(93).Syndesmos = ""
#End Region
#Region "<tbody>"
            ReDim packHTML(94).HTMLIDIOTHTES(-1)
            packHTML(94).Etiketa = "<tbody>"
            packHTML(94).onomasia = "σώμα-πίνακα"
            packHTML(94).ELtrans = "<σώμα-πίνακα>"
            packHTML(94).Perigrafh = "Η ετικέτα <tbody> χρησιμοποιείται για την ομαδοποίηση του περιεχομένου του σώματος σε έναν πίνακα HTML."
            packHTML(94).Syndesmos = ""
#End Region
#Region "<td>"
            ReDim packHTML(95).HTMLIDIOTHTES(2)
            ReDim packHTML(95).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(95).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(95).HTMLIDIOTHTES(2).values(0)
            packHTML(95).Etiketa = "<td>"
            packHTML(95).onomasia = "σώμα-πίνακα"
            packHTML(95).ELtrans = "<σώμα-πίνακα>"
            packHTML(95).Perigrafh = "Η ετικέτα <td> ορίζει ένα τυπικό κελί δεδομένων σε έναν πίνακα HTML."
            packHTML(95).Syndesmos = ""

            packHTML(95).HTMLIDIOTHTES(0).idiothta = "colspan"
            packHTML(95).HTMLIDIOTHTES(0).Eltrans = "εκτείνεται-κελί"
            packHTML(95).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει τον αριθμό των στηλών που πρέπει να εκτείνεται σε ένα κελί"

            packHTML(95).HTMLIDIOTHTES(1).idiothta = "headers"
            packHTML(95).HTMLIDIOTHTES(1).Eltrans = "κεφαλίδες"
            packHTML(95).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει ένα ή περισσότερα κελιά κεφαλίδας με τα οποία σχετίζεται ένα κελί"

            packHTML(95).HTMLIDIOTHTES(2).idiothta = "rowspan"
            packHTML(95).HTMLIDIOTHTES(2).Eltrans = "εύρος-σειρών"
            packHTML(95).HTMLIDIOTHTES(2).Perigrafh = "Ορίζει τον αριθμό των γραμμών που πρέπει να εκτείνεται ένα κελί"

            packHTML(95).HTMLIDIOTHTES(0).values(0).onoma = "(number)"
            packHTML(95).HTMLIDIOTHTES(0).values(0).ellinika = "(number)"
            packHTML(95).HTMLIDIOTHTES(0).values(0).perigrafh = "Καθορίζει τον αριθμό των στηλών που πρέπει να εκτείνεται σε ένα κελ"

            packHTML(95).HTMLIDIOTHTES(1).values(0).onoma = "(header_id)"
            packHTML(95).HTMLIDIOTHTES(1).values(0).ellinika = "(header_id)"
            packHTML(95).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει μια λίστα αναγνωριστικών χωρισμένη σε διάστημα σε ένα ή περισσότερα κελιά κεφαλίδας με τα οποία σχετίζεται το κελί του πίνακα"

            packHTML(95).HTMLIDIOTHTES(2).values(0).onoma = "(number)"
            packHTML(95).HTMLIDIOTHTES(2).values(0).ellinika = "(number)"
            packHTML(95).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει τον αριθμό των σειρών που πρέπει να εκτείνεται σε ένα κελί. Σημείωση: Το rowspan='0' λέει στο πρόγραμμα περιήγησης να εκτείνεται από το κελί στην τελευταία γραμμή της ενότητας του πίνακα (thead, tbody ή tfoot). Οι Chrome, Firefox και Opera 12 (και παλαιότερες εκδόσεις) υποστηρίζουν το rowspan='0'."
#End Region
#Region "<template>"
            ReDim packHTML(96).HTMLIDIOTHTES(-1)
            packHTML(96).Etiketa = "<template>"
            packHTML(96).onomasia = "πρότυπο"
            packHTML(96).ELtrans = "<πρότυπο>"
            packHTML(96).Perigrafh = "Καθορίζει ένα κοντέινερ για περιεχόμενο που θα πρέπει να είναι κρυφό κατά τη φόρτωση της σελίδας"
            packHTML(96).Syndesmos = ""
#End Region
#Region "<textarea>"
            ReDim packHTML(97).HTMLIDIOTHTES(11)
            ReDim packHTML(97).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(97).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(97).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(97).HTMLIDIOTHTES(3).values(-1)
            ReDim packHTML(97).HTMLIDIOTHTES(4).values(0)
            ReDim packHTML(97).HTMLIDIOTHTES(5).values(0)
            ReDim packHTML(97).HTMLIDIOTHTES(6).values(0)
            ReDim packHTML(97).HTMLIDIOTHTES(7).values(0)
            ReDim packHTML(97).HTMLIDIOTHTES(8).values(-1)
            ReDim packHTML(97).HTMLIDIOTHTES(9).values(-1)
            ReDim packHTML(97).HTMLIDIOTHTES(10).values(0)
            ReDim packHTML(97).HTMLIDIOTHTES(11).values(1)

            packHTML(97).Etiketa = "<textarea>"
            packHTML(97).onomasia = "εισαγωγής-κειμένου"
            packHTML(97).ELtrans = "<εισαγωγής-κειμένου>"
            packHTML(97).Perigrafh = "Η ετικέτα <textarea> ορίζει ένα στοιχείο ελέγχου εισαγωγής κειμένου πολλών γραμμών."
            packHTML(97).Syndesmos = ""
            '--------- ATTRIBUTES autofocus--------'
            packHTML(97).HTMLIDIOTHTES(0).idiothta = "autofocus"
            packHTML(97).HTMLIDIOTHTES(0).Eltrans = "αυτόματη-εστίαση"
            packHTML(97).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι μια περιοχή κειμένου θα πρέπει να εστιάζει αυτόματα κατά τη φόρτωση της σελίδας"
            packHTML(97).HTMLIDIOTHTES(0).syndesmos = ""
            '--------- ATTRIBUTES cols--------'
            packHTML(97).HTMLIDIOTHTES(1).idiothta = "cols"
            packHTML(97).HTMLIDIOTHTES(1).Eltrans = "ορατό-πλάτος"
            packHTML(97).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει το ορατό πλάτος μιας περιοχής κειμένου"
            packHTML(97).HTMLIDIOTHTES(1).syndesmos = ""
            '--------- ATTRIBUTES dirname--------'
            packHTML(97).HTMLIDIOTHTES(2).idiothta = "dirname"
            packHTML(97).HTMLIDIOTHTES(2).Eltrans = "κατεύθυνση-κειμένου"
            packHTML(97).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει ότι θα υποβληθεί η κατεύθυνση κειμένου της περιοχής κειμένου"
            packHTML(97).HTMLIDIOTHTES(2).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(3).idiothta = "disabled"
            packHTML(97).HTMLIDIOTHTES(3).Eltrans = "απενεργοποιημένη"
            packHTML(97).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει ότι μια περιοχή κειμένου πρέπει να είναι απενεργοποιημένη"
            packHTML(97).HTMLIDIOTHTES(3).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(4).idiothta = "form"
            packHTML(97).HTMLIDIOTHTES(4).Eltrans = "φόρμα"
            packHTML(97).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει σε ποια μορφή ανήκει η περιοχή κειμένου"
            packHTML(97).HTMLIDIOTHTES(4).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(5).idiothta = "maxlength"
            packHTML(97).HTMLIDIOTHTES(5).Eltrans = "μέγιστο-μήκος"
            packHTML(97).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει τον μέγιστο αριθμό χαρακτήρων που επιτρέπεται στην περιοχή κειμένου"
            packHTML(97).HTMLIDIOTHTES(5).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(6).idiothta = "name"
            packHTML(97).HTMLIDIOTHTES(6).Eltrans = "όνομα"
            packHTML(97).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει ένα όνομα για μια περιοχή κειμένου"
            packHTML(97).HTMLIDIOTHTES(6).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(7).idiothta = "placeholder"
            packHTML(97).HTMLIDIOTHTES(7).Eltrans = "κράτησης-θέσης"
            packHTML(97).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει μια σύντομη υπόδειξη που περιγράφει την αναμενόμενη τιμή μιας περιοχής κειμένου"
            packHTML(97).HTMLIDIOTHTES(7).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(8).idiothta = "readonly"
            packHTML(97).HTMLIDIOTHTES(8).Eltrans = "μόνο-ανάγνωση"
            packHTML(97).HTMLIDIOTHTES(8).Perigrafh = "Καθορίζει ότι μια περιοχή κειμένου πρέπει να είναι μόνο για ανάγνωση"
            packHTML(97).HTMLIDIOTHTES(8).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(9).idiothta = "required"
            packHTML(97).HTMLIDIOTHTES(9).Eltrans = "απαιτείται"
            packHTML(97).HTMLIDIOTHTES(9).Perigrafh = "Καθορίζει ότι απαιτείται/πρέπει να συμπληρωθεί μια περιοχή κειμένου"
            packHTML(97).HTMLIDIOTHTES(9).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(10).idiothta = "rows"
            packHTML(97).HTMLIDIOTHTES(10).Eltrans = "σειρές"
            packHTML(97).HTMLIDIOTHTES(10).Perigrafh = "Καθορίζει τον ορατό αριθμό γραμμών σε μια περιοχή κειμένου"
            packHTML(97).HTMLIDIOTHTES(10).syndesmos = ""
            '--------- ATTRIBUTES --------'
            packHTML(97).HTMLIDIOTHTES(11).idiothta = "wrap"
            packHTML(97).HTMLIDIOTHTES(11).Eltrans = "περιτυλίσσω"
            packHTML(97).HTMLIDIOTHTES(11).Perigrafh = "Καθορίζει τον τρόπο με τον οποίο θα αναδιπλώνεται το κείμενο σε μια περιοχή κειμένου όταν υποβάλλεται σε μια φόρμα"
            packHTML(97).HTMLIDIOTHTES(11).syndesmos = ""

            packHTML(97).HTMLIDIOTHTES(1).values(0).onoma = "(number)"
            packHTML(97).HTMLIDIOTHTES(1).values(0).ellinika = "(number)"
            packHTML(97).HTMLIDIOTHTES(1).values(0).perigrafh = "Καθορίζει το πλάτος της περιοχής κειμένου (σε μέσο πλάτος χαρακτήρων). Η προεπιλεγμένη τιμή είναι 20"

            packHTML(97).HTMLIDIOTHTES(2).values(0).onoma = "(name.dir)"
            packHTML(97).HTMLIDIOTHTES(2).values(0).ellinika = "(name.dir)"
            packHTML(97).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει ότι θα υποβληθεί η κατεύθυνση κειμένου της περιοχής κειμένου."

            packHTML(97).HTMLIDIOTHTES(4).values(0).onoma = "(form_id)"
            packHTML(97).HTMLIDIOTHTES(4).values(0).ellinika = "(form_id)"
            packHTML(97).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει το στοιχείο φόρμας στο οποίο ανήκει το στοιχείο <textarea>. Η τιμή αυτού του χαρακτηριστικού πρέπει να είναι το χαρακτηριστικό id ενός στοιχείου <form> στο ίδιο έγγραφο."

            packHTML(97).HTMLIDIOTHTES(5).values(0).onoma = "(number)"
            packHTML(97).HTMLIDIOTHTES(5).values(0).ellinika = "(number)"
            packHTML(97).HTMLIDIOTHTES(5).values(0).perigrafh = "Ο μέγιστος επιτρεπόμενος αριθμός χαρακτήρων στην περιοχή κειμένου"

            packHTML(97).HTMLIDIOTHTES(6).values(0).onoma = "(text)"
            packHTML(97).HTMLIDIOTHTES(6).values(0).ellinika = "(text)"
            packHTML(97).HTMLIDIOTHTES(6).values(0).perigrafh = "Καθορίζει το όνομα της περιοχής κειμένου"

            packHTML(97).HTMLIDIOTHTES(7).values(0).onoma = "(text)"
            packHTML(97).HTMLIDIOTHTES(7).values(0).ellinika = "(text)"
            packHTML(97).HTMLIDIOTHTES(7).values(0).perigrafh = "Καθορίζει μια σύντομη υπόδειξη που περιγράφει την αναμενόμενη τιμή της περιοχής κειμένου"

            packHTML(97).HTMLIDIOTHTES(10).values(0).onoma = "(number)"
            packHTML(97).HTMLIDIOTHTES(10).values(0).ellinika = "(number)"
            packHTML(97).HTMLIDIOTHTES(10).values(0).perigrafh = "Καθορίζει το ύψος της περιοχής κειμένου (σε γραμμές). Η προεπιλεγμένη τιμή είναι 2"

            packHTML(97).HTMLIDIOTHTES(11).values(0).onoma = "soft"
            packHTML(97).HTMLIDIOTHTES(11).values(0).ellinika = "μαλακός"
            packHTML(97).HTMLIDIOTHTES(11).values(0).perigrafh = "Το κείμενο στην περιοχή κειμένου δεν αναδιπλώνεται όταν υποβάλλεται σε φόρμα. Αυτό είναι προεπιλογή"

            packHTML(97).HTMLIDIOTHTES(11).values(1).onoma = "hard"
            packHTML(97).HTMLIDIOTHTES(11).values(1).ellinika = "σκληρά"
            packHTML(97).HTMLIDIOTHTES(11).values(1).perigrafh = "Το κείμενο στην περιοχή κειμένου αναδιπλώνεται (περιέχει νέες γραμμές) όταν υποβάλλεται σε μια φόρμα. Όταν χρησιμοποιείται 'σκληρό', πρέπει να καθοριστεί το χαρακτηριστικό cols"

#End Region
#Region "<tfoot>"
            ReDim packHTML(98).HTMLIDIOTHTES(-1)
            packHTML(98).Etiketa = "<tfoot>"
            packHTML(98).onomasia = "Ομαδοποιεί-πίνακα"
            packHTML(98).ELtrans = "<Ομαδοποιεί-πίνακα>"
            packHTML(98).Perigrafh = "Η ετικέτα <tfoot> χρησιμοποιείται για την ομαδοποίηση του περιεχομένου υποσέλιδου σε έναν πίνακα HTML."
            packHTML(98).Syndesmos = ""
#End Region
#Region "<th>"
            ReDim packHTML(99).HTMLIDIOTHTES(4)
            ReDim packHTML(99).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(99).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(99).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(99).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(99).HTMLIDIOTHTES(4).values(3)

            packHTML(99).Etiketa = "<th>"
            packHTML(99).onomasia = "κεφαλίδας-πίνακα"
            packHTML(99).ELtrans = "<κεφαλίδας-πίνακα>"
            packHTML(99).Perigrafh = "Η ετικέτα <th> ορίζει ένα κελί κεφαλίδας σε έναν πίνακα HTML."
            packHTML(99).Syndesmos = ""

            packHTML(99).HTMLIDIOTHTES(0).idiothta = "abbr"
            packHTML(99).HTMLIDIOTHTES(0).Eltrans = "συντομευμένη"
            packHTML(99).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει μια συντομευμένη έκδοση του περιεχομένου σε ένα κελί κεφαλίδας"
            packHTML(99).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(99).HTMLIDIOTHTES(1).idiothta = "colspan"
            packHTML(99).HTMLIDIOTHTES(1).Eltrans = "εκτείνεται-στηλών"
            packHTML(99).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει τον αριθμό των στηλών που πρέπει να εκτείνεται σε ένα κελί κεφαλίδας"
            packHTML(99).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(99).HTMLIDIOTHTES(2).idiothta = "headers"
            packHTML(99).HTMLIDIOTHTES(2).Eltrans = "κεφαλίδες"
            packHTML(99).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει ένα ή περισσότερα κελιά κεφαλίδας με τα οποία σχετίζεται ένα κελί"
            packHTML(99).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(99).HTMLIDIOTHTES(3).idiothta = "rowspan"
            packHTML(99).HTMLIDIOTHTES(3).Eltrans = "εύρος-σειρών"
            packHTML(99).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει τον αριθμό των σειρών που πρέπει να εκτείνεται σε ένα κελί κεφαλίδας"
            packHTML(99).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(99).HTMLIDIOTHTES(4).idiothta = "scope"
            packHTML(99).HTMLIDIOTHTES(4).Eltrans = "πεδίο"
            packHTML(99).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει εάν ένα κελί κεφαλίδας είναι κεφαλίδα για στήλη, γραμμή ή ομάδα στηλών ή σειρών"
            packHTML(99).HTMLIDIOTHTES(4).syndesmos = ""

            packHTML(99).HTMLIDIOTHTES(0).values(0).onoma = "(text)"
            packHTML(99).HTMLIDIOTHTES(0).values(0).ellinika = "(text)"
            packHTML(99).HTMLIDIOTHTES(0).values(0).perigrafh = "Μια σύντομη περιγραφή του περιεχομένου του κελιού κεφαλίδας"

            packHTML(99).HTMLIDIOTHTES(1).values(0).onoma = "(number)"
            packHTML(99).HTMLIDIOTHTES(1).values(0).ellinika = "(number)"
            packHTML(99).HTMLIDIOTHTES(1).values(0).perigrafh = "Ορίζει τον αριθμό των στηλών που πρέπει να εκτείνεται σε ένα κελί κεφαλίδας. Σημείωση: colspan='0' λέει στο πρόγραμμα περιήγησης να εκτείνεται το κελί στην τελευταία στήλη της ομάδας στηλών (colgroup)"

            packHTML(99).HTMLIDIOTHTES(2).values(0).onoma = "(header_id)"
            packHTML(99).HTMLIDIOTHTES(2).values(0).ellinika = "(header_id)"
            packHTML(99).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει μια λίστα αναγνωριστικών διαχωρισμένη με διάστημα σε ένα ή περισσότερα κελιά κεφαλίδας με τα οποία σχετίζεται το κελί κεφαλίδας"

            packHTML(99).HTMLIDIOTHTES(3).values(0).onoma = "(number)"
            packHTML(99).HTMLIDIOTHTES(3).values(0).ellinika = "(number)"
            packHTML(99).HTMLIDIOTHTES(3).values(0).perigrafh = "Ορίζει τον αριθμό των σειρών που πρέπει να εκτείνεται σε ένα κελί κεφαλίδας. Σημείωση: Το rowspan='0' λέει στο πρόγραμμα περιήγησης να εκτείνεται από το κελί στην τελευταία γραμμή της ενότητας του πίνακα (thead, tbody ή tfoot)"

            packHTML(99).HTMLIDIOTHTES(4).values(0).onoma = "col"
            packHTML(99).HTMLIDIOTHTES(4).values(0).ellinika = "κελί-κεφαλίδα"
            packHTML(99).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει ότι το κελί είναι μια κεφαλίδα για μια στήλη"

            packHTML(99).HTMLIDIOTHTES(4).values(1).onoma = "row"
            packHTML(99).HTMLIDIOTHTES(4).values(1).ellinika = "σειρά"
            packHTML(99).HTMLIDIOTHTES(4).values(1).perigrafh = "Καθορίζει ότι το κελί είναι μια κεφαλίδα για μια σειρά"

            packHTML(99).HTMLIDIOTHTES(4).values(2).onoma = "colgroup"
            packHTML(99).HTMLIDIOTHTES(4).values(2).ellinika = "ομάδα-στηλών"
            packHTML(99).HTMLIDIOTHTES(4).values(2).perigrafh = "Καθορίζει ότι το κελί είναι μια κεφαλίδα για μια ομάδα στηλών"

            packHTML(99).HTMLIDIOTHTES(4).values(3).onoma = "rowgroup"
            packHTML(99).HTMLIDIOTHTES(4).values(3).ellinika = "ομάδα-σειρών"
            packHTML(99).HTMLIDIOTHTES(4).values(3).perigrafh = "Καθορίζει ότι το κελί είναι μια κεφαλίδα για μια ομάδα σειρών"

#End Region
#Region "<thead>"
            ReDim packHTML(100).HTMLIDIOTHTES(-1)
            packHTML(100).Etiketa = "<thead>"
            packHTML(100).onomasia = "Ομαδοποιεί-περιεχόμενο"
            packHTML(100).ELtrans = "<Ομαδοποιεί-περιεχόμενο>"
            packHTML(100).Perigrafh = "Ομαδοποιεί το περιεχόμενο της κεφαλίδας σε έναν πίνακα"
            packHTML(100).Syndesmos = ""
#End Region
#Region "<time>"
            ReDim packHTML(101).HTMLIDIOTHTES(0)
            ReDim packHTML(101).HTMLIDIOTHTES(0).values(0)
            packHTML(101).Etiketa = "<time>"
            packHTML(101).onomasia = "ώρα"
            packHTML(101).ELtrans = "<ώρα>"
            packHTML(101).Perigrafh = "Η ετικέτα <time> ορίζει μια συγκεκριμένη ώρα (ή ημερομηνία ώρα)."
            packHTML(101).Syndesmos = ""

            packHTML(101).HTMLIDIOTHTES(0).idiothta = "datetime"
            packHTML(101).HTMLIDIOTHTES(0).Eltrans = "ημερομηνία-ώρα"
            packHTML(101).HTMLIDIOTHTES(0).Perigrafh = "Αντιπροσωπεύουν μια μηχανικά αναγνώσιμη μορφή του στοιχείου <time>"
            packHTML(101).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(101).HTMLIDIOTHTES(0).values(0).onoma = "(YYYY-MM-DDThh:mm:ssTZD or PTDHMS)"
            packHTML(101).HTMLIDIOTHTES(0).values(0).ellinika = "(YYYY-MM-DDThh:mm:ssTZD or PTDHMS)"
            packHTML(101).HTMLIDIOTHTES(0).values(0).perigrafh = "YYYY - έτος (π.χ. 2011) ΜΜ - μήνας (π.χ. 01 Ιανουαρίου)
ΗΗ - ημέρα του μήνα (π.χ. 08) 
T ή ένα διάστημα - ένα διαχωριστικό (απαιτείται εάν έχει επίσης καθοριστεί ο χρόνος) 
ωω - ώρα (π.χ. 22 για τις 22:00)
mm - λεπτά (π.χ. 55) ss - δευτερόλεπτα (π.χ. 03) 
TZD - Προσδιορισμός ζώνης ώρας (το Z υποδηλώνει τα Ζουλού, γνωστό και ως Μέση ώρα Γκρίνουιτς)
P - ένα πρόθεμα για 'Περίοδος'
D - ένα πρόθεμα για 'Ημέρες'
H - ένα πρόθεμα για 'Ώρες' 
M - ένα πρόθεμα για 'Λεπτά' 
S - ένα πρόθεμα για 'δευτερόλεπτα'"
#End Region
#Region "<title>"
            ReDim packHTML(102).HTMLIDIOTHTES(-1)
            packHTML(102).Etiketa = "<title>"
            packHTML(102).onomasia = "τίτλο"
            packHTML(102).ELtrans = "<τίτλο>"
            packHTML(102).Perigrafh = "Ορίζει έναν τίτλο για το έγγραφο"
            packHTML(102).Syndesmos = ""
#End Region
#Region "<tr>"
            ReDim packHTML(103).HTMLIDIOTHTES(-1)
            packHTML(103).Etiketa = "<tr>"
            packHTML(103).onomasia = "σειρά"
            packHTML(103).ELtrans = "<σειρά>"
            packHTML(103).Perigrafh = "Ορίζει μια σειρά σε έναν πίνακα"
            packHTML(103).Syndesmos = ""
#End Region
#Region "<track>"
            ReDim packHTML(104).HTMLIDIOTHTES(4)
            ReDim packHTML(104).HTMLIDIOTHTES(0).values(-1)
            ReDim packHTML(104).HTMLIDIOTHTES(1).values(4)
            ReDim packHTML(104).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(104).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(104).HTMLIDIOTHTES(4).values(0)
            packHTML(104).Etiketa = "<track>"
            packHTML(104).onomasia = "πολυμέσων"
            packHTML(104).ELtrans = "<πολυμέσων>"
            packHTML(104).Perigrafh = "Καθορίζει κομμάτια κειμένου για στοιχεία πολυμέσων (<video> και <audio>"
            packHTML(104).Syndesmos = ""

            packHTML(104).HTMLIDIOTHTES(0).idiothta = "default"
            packHTML(104).HTMLIDIOTHTES(0).Eltrans = "Προκαθορισμένο"
            packHTML(104).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι το κομμάτι θα ενεργοποιηθεί εάν οι προτιμήσεις του χρήστη δεν υποδεικνύουν ότι άλλο κομμάτι θα ήταν καταλληλότερο"
            packHTML(104).HTMLIDIOTHTES(0).syndesmos = ""

            packHTML(104).HTMLIDIOTHTES(1).idiothta = "kind"
            packHTML(104).HTMLIDIOTHTES(1).Eltrans = "είδος"
            packHTML(104).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει το είδος του κομματιού κειμένου"
            packHTML(104).HTMLIDIOTHTES(1).syndesmos = ""

            packHTML(104).HTMLIDIOTHTES(2).idiothta = "label"
            packHTML(104).HTMLIDIOTHTES(2).Eltrans = "επιγραφή"
            packHTML(104).HTMLIDIOTHTES(2).Perigrafh = "Καθορίζει τον τίτλο του κομματιού κειμένου"
            packHTML(104).HTMLIDIOTHTES(2).syndesmos = ""

            packHTML(104).HTMLIDIOTHTES(3).idiothta = "src"
            packHTML(104).HTMLIDIOTHTES(3).Eltrans = "διεύθυνση"
            packHTML(104).HTMLIDIOTHTES(3).Perigrafh = "Απαιτείται. Καθορίζει τη διεύθυνση URL του αρχείου κομματιού"
            packHTML(104).HTMLIDIOTHTES(3).syndesmos = ""

            packHTML(104).HTMLIDIOTHTES(4).idiothta = "srclang"
            packHTML(104).HTMLIDIOTHTES(4).Eltrans = "γλώσσα-δεδομένων"
            packHTML(104).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει τη γλώσσα των δεδομένων κειμένου του κομματιού (απαιτείται εάν kind='subtitles')"
            packHTML(104).HTMLIDIOTHTES(4).syndesmos = ""

            packHTML(104).HTMLIDIOTHTES(1).values(0).onoma = "captions"
            packHTML(104).HTMLIDIOTHTES(1).values(0).ellinika = "λεζάντες"
            packHTML(104).HTMLIDIOTHTES(1).values(0).perigrafh = "Το κομμάτι ορίζει τη μετάφραση διαλόγων και ηχητικά εφέ (κατάλληλο για κωφούς χρήστες)"

            packHTML(104).HTMLIDIOTHTES(1).values(1).onoma = "chapters"
            packHTML(104).HTMLIDIOTHTES(1).values(1).ellinika = "Κεφάλαια"
            packHTML(104).HTMLIDIOTHTES(1).values(1).perigrafh = "Το κομμάτι ορίζει τίτλους κεφαλαίων (κατάλληλο για πλοήγηση στον πόρο πολυμέσων)"

            packHTML(104).HTMLIDIOTHTES(1).values(2).onoma = "descriptions"
            packHTML(104).HTMLIDIOTHTES(1).values(2).ellinika = "περιγραφές"
            packHTML(104).HTMLIDIOTHTES(1).values(2).perigrafh = "Το κομμάτι ορίζει μια περιγραφή κειμένου του περιεχομένου βίντεο (κατάλληλο για τυφλούς χρήστες)"

            packHTML(104).HTMLIDIOTHTES(1).values(3).onoma = "metadata"
            packHTML(104).HTMLIDIOTHTES(1).values(3).ellinika = "μεταδεδομένα"
            packHTML(104).HTMLIDIOTHTES(1).values(3).perigrafh = "Το κομμάτι ορίζει περιεχόμενο που χρησιμοποιείται από σενάρια. Δεν είναι ορατό για τον χρήστη"

            packHTML(104).HTMLIDIOTHTES(1).values(4).onoma = "subtitles"
            packHTML(104).HTMLIDIOTHTES(1).values(4).ellinika = "Υπότιτλοι"
            packHTML(104).HTMLIDIOTHTES(1).values(4).perigrafh = "Το κομμάτι ορίζει υπότιτλους, που χρησιμοποιούνται για την εμφάνιση υπότιτλων σε ένα βίντεο"

            packHTML(104).HTMLIDIOTHTES(2).values(0).onoma = "(label)"
            packHTML(104).HTMLIDIOTHTES(2).values(0).ellinika = "(label)"
            packHTML(104).HTMLIDIOTHTES(2).values(0).perigrafh = "Καθορίζει τον τίτλο του κομματιού κειμένου"

            packHTML(104).HTMLIDIOTHTES(3).values(0).onoma = "(URL)"
            packHTML(104).HTMLIDIOTHTES(3).values(0).ellinika = "(URL)"
            packHTML(104).HTMLIDIOTHTES(3).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL του κομματιού"

            packHTML(104).HTMLIDIOTHTES(4).values(0).onoma = "(language_code)"
            packHTML(104).HTMLIDIOTHTES(4).values(0).ellinika = "(language_code)"
            packHTML(104).HTMLIDIOTHTES(4).values(0).perigrafh = "Καθορίζει έναν κωδικό γλώσσας δύο γραμμάτων που καθορίζει τη γλώσσα των δεδομένων κειμένου του κομματιού"
#End Region
#Region "<u>"
            ReDim packHTML(105).HTMLIDIOTHTES(-1)
            packHTML(105).Etiketa = "<u>"
            packHTML(105).onomasia = "υπογράμμιση"
            packHTML(105).ELtrans = "<υπογράμμιση>"
            packHTML(105).Perigrafh = "Ορίζει κάποιο κείμενο που δεν είναι αρθρωμένο και έχει διαφορετικό στυλ από το κανονικό κείμενο"
            packHTML(105).Syndesmos = ""
#End Region
#Region "<ul>"
            ReDim packHTML(106).HTMLIDIOTHTES(-1)
            packHTML(106).Etiketa = "<ul>"
            packHTML(106).onomasia = "κουκκίδες"
            packHTML(106).ELtrans = "<κουκκίδες>"
            packHTML(106).Perigrafh = "Καθορίζει μια μη ταξινομημένη λίστα"
            packHTML(106).Syndesmos = ""
#End Region
#Region "<var>"
            ReDim packHTML(107).HTMLIDIOTHTES(-1)
            packHTML(107).Etiketa = "<var>"
            packHTML(107).onomasia = "μεταβλητή"
            packHTML(107).ELtrans = "<μεταβλητή>"
            packHTML(107).Perigrafh = "Ορίζει μια μεταβλητή"
            packHTML(107).Syndesmos = ""
#End Region
#Region "<video>"
            ReDim packHTML(108).HTMLIDIOTHTES(8)
            ReDim packHTML(108).HTMLIDIOTHTES(0).values(0)
            ReDim packHTML(108).HTMLIDIOTHTES(1).values(0)
            ReDim packHTML(108).HTMLIDIOTHTES(2).values(0)
            ReDim packHTML(108).HTMLIDIOTHTES(3).values(0)
            ReDim packHTML(108).HTMLIDIOTHTES(4).values(0)
            ReDim packHTML(108).HTMLIDIOTHTES(5).values(0)
            ReDim packHTML(108).HTMLIDIOTHTES(6).values(2)
            ReDim packHTML(108).HTMLIDIOTHTES(7).values(0)
            ReDim packHTML(108).HTMLIDIOTHTES(8).values(0)
            ReDim packHTML(108).Events(23)
            packHTML(108).Etiketa = "<video>"
            packHTML(108).onomasia = "βίντεο"
            packHTML(108).ELtrans = "<βίντεο>"
            packHTML(108).Perigrafh = "Καθορίζει το ενσωματωμένο περιεχόμενο βίντεο"
            packHTML(108).Syndesmos = ""
#Region "Events"
            packHTML(108).Events(0).onoma = "onabort"
            packHTML(108).Events(0).Ellinika = "ακύρωση"
            packHTML(108).Events(0).Perigrafh = "Σενάριο που θα εκτελεστεί κατά την ακύρωση"

            packHTML(108).Events(1).onoma = "oncanplay"
            packHTML(108).Events(1).Ellinika = "ξεκινήσει-αναπαραγωγή"
            packHTML(108).Events(1).Perigrafh = "Σενάριο που θα εκτελεστεί όταν ένα αρχείο είναι έτοιμο να ξεκινήσει η αναπαραγωγή (όταν έχει τοποθετηθεί αρκετά buffer για να ξεκινήσει)"

            packHTML(108).Events(2).onoma = "oncanplaythrough"
            packHTML(108).Events(2).Ellinika = "αποθήκευση-αναπαραχθεί"
            packHTML(108).Events(2).Perigrafh = "Σενάριο που θα εκτελεστεί όταν ένα αρχείο μπορεί να αναπαραχθεί μέχρι το τέλος χωρίς παύση για προσωρινή αποθήκευση"

            packHTML(108).Events(3).onoma = "oncuechange"
            packHTML(108).Events(3).Ellinika = "αλλάζει-στοιχείο"
            packHTML(108).Events(3).Perigrafh = "Σενάριο που θα εκτελεστεί όταν η υπόδειξη αλλάζει σε ένα στοιχείο <track>"

            packHTML(108).Events(4).onoma = "ondurationchange"
            packHTML(108).Events(4).Ellinika = "αλλαγή-διάρκειας"
            packHTML(108).Events(4).Perigrafh = "Σενάριο που εκτελείται όταν αλλάζει το μήκος του μέσου"


            packHTML(108).Events(5).onoma = "onemptied"
            packHTML(108).Events(5).Ellinika = "απροσδόκητη-αποσύνδεση"
            packHTML(108).Events(5).Perigrafh = "Σενάριο που θα εκτελεστεί όταν συμβαίνει κάτι κακό και το αρχείο είναι ξαφνικά μη διαθέσιμο (όπως απροσδόκητη αποσύνδεση)"

            packHTML(108).Events(6).onoma = "onemptied"
            packHTML(108).Events(6).Ellinika = "τέλος"
            packHTML(108).Events(6).Perigrafh = "Σενάριο που θα εκτελεστεί όταν τα μέσα έχουν φτάσει στο τέλος (ένα χρήσιμο συμβάν για μηνύματα όπως 'ευχαριστώ που ακούσατε')"

            packHTML(108).Events(7).onoma = "onended"
            packHTML(108).Events(7).Ellinika = "στο-τέλος"
            packHTML(108).Events(7).Perigrafh = "Σενάριο που θα εκτελεστεί όταν τα μέσα έχουν φτάσει στο τέλος (ένα χρήσιμο συμβάν για μηνύματα όπως 'ευχαριστώ που ακούσατε')"

            packHTML(108).Events(8).onoma = "onerror"
            packHTML(108).Events(8).Ellinika = "λάθος"
            packHTML(108).Events(8).Perigrafh = "Σενάριο που θα εκτελεστεί όταν παρουσιαστεί σφάλμα κατά τη φόρτωση του αρχείου"

            packHTML(108).Events(9).onoma = "onloadeddata"
            packHTML(108).Events(9).Ellinika = "εκφορτωμένα-δεδομένα"
            packHTML(108).Events(9).Perigrafh = "Σενάριο για εκτέλεση κατά τη φόρτωση δεδομένων πολυμέσων"

            packHTML(108).Events(10).onoma = "onloadedmetdada"
            packHTML(108).Events(10).Ellinika = "φορτώνονται-μεταδεδομένα"
            packHTML(108).Events(10).Perigrafh = "Σενάριο που θα εκτελείται όταν φορτώνονται μεταδεδομένα (όπως διαστάσεις και διάρκεια)."

            packHTML(108).Events(11).onoma = "onloadstart"
            packHTML(108).Events(11).Ellinika = "αρχίζει-φορτωθεί"
            packHTML(108).Events(11).Perigrafh = "Η δέσμη ενεργειών θα εκτελεστεί ακριβώς τη στιγμή που το αρχείο αρχίζει να φορτώνεται πριν φορτωθεί οτιδήποτε"

            packHTML(108).Events(12).onoma = "onpause"
            packHTML(108).Events(12).Ellinika = "παύση"
            packHTML(108).Events(12).Perigrafh = "Σενάριο που εκτελείται όταν το μέσο τίθεται σε παύση είτε από τον χρήστη είτε μέσω προγραμματισμού"

            packHTML(108).Events(13).onoma = "onplay"
            packHTML(108).Events(13).Ellinika = "έτοιμο-ξεκινήσει"
            packHTML(108).Events(13).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το μέσο είναι έτοιμο να ξεκινήσει την αναπαραγωγή"

            packHTML(108).Events(14).onoma = "onplaying"
            packHTML(108).Events(14).Ellinika = "αρχίσει-παίζει"
            packHTML(108).Events(14).Perigrafh = "Σενάριο που θα εκτελεστεί όταν τα πολυμέσα έχουν αρχίσει πραγματικά να παίζουν"

            packHTML(108).Events(15).onoma = "onprogress"
            packHTML(108).Events(15).Ellinika = "διαδικασία-λήψης"
            packHTML(108).Events(15).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το πρόγραμμα περιήγησης βρίσκεται στη διαδικασία λήψης των δεδομένων πολυμέσων"

            packHTML(108).Events(16).onoma = "onratechange"
            packHTML(108).Events(16).Ellinika = "αλλάζει-αναπαραγωγής"
            packHTML(108).Events(16).Perigrafh = "Σενάριο που θα εκτελείται κάθε φορά που αλλάζει ο ρυθμός αναπαραγωγής (όπως όταν ένας χρήστης αλλάζει σε λειτουργία αργής κίνησης ή γρήγορης προώθησης)"


            packHTML(108).Events(17).onoma = "onseeked"
            packHTML(108).Events(17).Ellinika = "αναζήτηση"
            packHTML(108).Events(17).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το χαρακτηριστικό αναζήτησης έχει οριστεί σε false υποδεικνύοντας ότι η αναζήτηση έχει τελειώσει"

            packHTML(108).Events(18).onoma = "onseeking"
            packHTML(108).Events(18).Ellinika = "αναζητώντας"
            packHTML(108).Events(18).Perigrafh = "Σενάριο που θα εκτελεστεί όταν το χαρακτηριστικό αναζήτησης έχει οριστεί σε true, υποδεικνύοντας ότι η αναζήτηση είναι ενεργή"

            packHTML(108).Events(19).onoma = "onstalled"
            packHTML(108).Events(19).Ellinika = "εγκατεστημένο"
            packHTML(108).Events(19).Perigrafh = "Σενάριο που εκτελείται όταν το πρόγραμμα περιήγησης δεν μπορεί να ανακτήσει τα δεδομένα πολυμέσων για οποιονδήποτε λόγο"

            packHTML(108).Events(20).onoma = "onsuspend"
            packHTML(108).Events(20).Ellinika = "διακόπτεται"
            packHTML(108).Events(20).Perigrafh = "Η δέσμη ενεργειών που εκτελείται κατά την ανάκτηση των δεδομένων πολυμέσων διακόπτεται πριν φορτωθούν πλήρως για οποιονδήποτε λόγο"

            packHTML(108).Events(21).onoma = "ontimeupdate"
            packHTML(108).Events(21).Ellinika = "αλλάξει-αναπαραγωγής"
            packHTML(108).Events(21).Perigrafh = "Σενάριο που εκτελείται όταν έχει αλλάξει η θέση αναπαραγωγής (όπως όταν ο χρήστης προωθεί γρήγορα σε διαφορετικό σημείο του μέσου)"

            packHTML(108).Events(22).onoma = "onvolumechange"
            packHTML(108).Events(22).Ellinika = "εναλλαγή-έντασης"
            packHTML(108).Events(22).Perigrafh = "Σενάριο που θα εκτελείται κάθε φορά που αλλάζει ο τόμος, το οποίο (περιλαμβάνει τη ρύθμιση της έντασης σε 'σίγαση')"

            packHTML(108).Events(23).onoma = "onwaiting"
            packHTML(108).Events(23).Ellinika = "αναμένεται-συνεχιστεί"
            packHTML(108).Events(23).Perigrafh = "Σενάριο που θα εκτελείται όταν το μέσο έχει σταματήσει αλλά αναμένεται να συνεχιστεί (όπως όταν το μέσο τίθεται σε παύση για αποθήκευση περισσότερων δεδομένων)"
#End Region
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(0).idiothta = "autoplay"
            packHTML(108).HTMLIDIOTHTES(0).Eltrans = "αυτόματη-αναπαραγωγή"
            packHTML(108).HTMLIDIOTHTES(0).Perigrafh = "Καθορίζει ότι το βίντεο θα ξεκινήσει να παίζει μόλις είναι έτοιμο"
            packHTML(108).HTMLIDIOTHTES(0).syndesmos = ""
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(1).idiothta = "controls"
            packHTML(108).HTMLIDIOTHTES(1).Eltrans = "ελέγχους"
            packHTML(108).HTMLIDIOTHTES(1).Perigrafh = "Καθορίζει ότι θα πρέπει να εμφανίζονται τα στοιχεία ελέγχου βίντεο (όπως ένα κουμπί αναπαραγωγής/παύσης κ.λπ.)."
            packHTML(108).HTMLIDIOTHTES(1).syndesmos = ""
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(2).idiothta = "height"
            packHTML(108).HTMLIDIOTHTES(2).Eltrans = "ύψος"
            packHTML(108).HTMLIDIOTHTES(2).Perigrafh = "Ρυθμίζει το ύψος του προγράμματος αναπαραγωγής βίντεο"
            packHTML(108).HTMLIDIOTHTES(2).syndesmos = ""
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(3).idiothta = "loop"
            packHTML(108).HTMLIDIOTHTES(3).Eltrans = "βρόχος"
            packHTML(108).HTMLIDIOTHTES(3).Perigrafh = "Καθορίζει ότι το βίντεο θα ξεκινά από την αρχή, κάθε φορά που τελειώνει"
            packHTML(108).HTMLIDIOTHTES(3).syndesmos = ""
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(4).idiothta = "muted"
            packHTML(108).HTMLIDIOTHTES(4).Eltrans = "σίγαση"
            packHTML(108).HTMLIDIOTHTES(4).Perigrafh = "Καθορίζει ότι η έξοδος ήχου του βίντεο θα πρέπει να είναι σε σίγαση"
            packHTML(108).HTMLIDIOTHTES(4).syndesmos = ""
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(5).idiothta = "poster"
            packHTML(108).HTMLIDIOTHTES(5).Eltrans = "αφίσα"
            packHTML(108).HTMLIDIOTHTES(5).Perigrafh = "Καθορίζει μια εικόνα που θα εμφανίζεται κατά τη λήψη του βίντεο ή έως ότου ο χρήστης πατήσει το κουμπί αναπαραγωγής"
            packHTML(108).HTMLIDIOTHTES(5).syndesmos = ""
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(6).idiothta = "preload"
            packHTML(108).HTMLIDIOTHTES(6).Eltrans = "προφόρτιση"
            packHTML(108).HTMLIDIOTHTES(6).Perigrafh = "Καθορίζει εάν και πώς ο συντάκτης πιστεύει ότι το βίντεο πρέπει να φορτωθεί κατά τη φόρτωση της σελίδας"
            packHTML(108).HTMLIDIOTHTES(6).syndesmos = ""
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(7).idiothta = "src"
            packHTML(108).HTMLIDIOTHTES(7).Eltrans = "διεύθυνση"
            packHTML(108).HTMLIDIOTHTES(7).Perigrafh = "Καθορίζει τη διεύθυνση URL του αρχείου βίντεο"
            packHTML(108).HTMLIDIOTHTES(7).syndesmos = ""
            '---------ATTRIBUTES --------'
            packHTML(108).HTMLIDIOTHTES(8).idiothta = "width"
            packHTML(108).HTMLIDIOTHTES(8).Eltrans = "πλάτος"
            packHTML(108).HTMLIDIOTHTES(8).Perigrafh = "Ορίζει το πλάτος του προγράμματος αναπαραγωγής βίντεο"
            packHTML(108).HTMLIDIOTHTES(8).syndesmos = ""

            '---------- VALUES ----------
            packHTML(108).HTMLIDIOTHTES(2).values(0).onoma = "(pixels)"
            packHTML(108).HTMLIDIOTHTES(2).values(0).ellinika = "(pixels)"
            packHTML(108).HTMLIDIOTHTES(2).values(0).perigrafh = "Το ύψος του βίντεο, σε pixel (δηλαδή ύψος = '100')"
            '---------- VALUES ----------
            packHTML(108).HTMLIDIOTHTES(5).values(0).onoma = "(URL)"
            packHTML(108).HTMLIDIOTHTES(5).values(0).ellinika = "(URL)"
            packHTML(108).HTMLIDIOTHTES(5).values(0).perigrafh = "Καθορίζει τη διεύθυνση URL του αρχείου εικόνας. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως href='http://www.example.com/poster.jpg') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο σε έναν ιστότοπο (όπως href='poster.jpg')"

            '---------- VALUES ----------
            packHTML(108).HTMLIDIOTHTES(6).values(0).onoma = "auto"
            packHTML(108).HTMLIDIOTHTES(6).values(0).ellinika = "ευτόματο"
            packHTML(108).HTMLIDIOTHTES(6).values(0).perigrafh = "Ο συγγραφέας πιστεύει ότι το πρόγραμμα περιήγησης πρέπει να φορτώσει ολόκληρο το βίντεο όταν φορτώσει η σελίδα"

            '---------- VALUES ----------
            packHTML(108).HTMLIDIOTHTES(6).values(1).onoma = "metadata"
            packHTML(108).HTMLIDIOTHTES(6).values(1).ellinika = "μεταδεδομένα"
            packHTML(108).HTMLIDIOTHTES(6).values(1).perigrafh = "Ο συγγραφέας πιστεύει ότι το πρόγραμμα περιήγησης θα πρέπει να φορτώνει μόνο μεταδεδομένα κατά τη φόρτωση της σελίδας"

            '---------- VALUES ----------
            packHTML(108).HTMLIDIOTHTES(6).values(2).onoma = "none"
            packHTML(108).HTMLIDIOTHTES(6).values(2).ellinika = "κανένα"
            packHTML(108).HTMLIDIOTHTES(6).values(2).perigrafh = "Ο συγγραφέας πιστεύει ότι το πρόγραμμα περιήγησης ΔΕΝ πρέπει να φορτώνει το βίντεο όταν φορτώνεται η σελίδα"

            '---------- VALUES ----------
            packHTML(108).HTMLIDIOTHTES(7).values(0).onoma = "(URL)"
            packHTML(108).HTMLIDIOTHTES(7).values(0).ellinika = "(URL)"
            packHTML(108).HTMLIDIOTHTES(7).values(0).perigrafh = "Το URL του αρχείου βίντεο. Πιθανές τιμές: Μια απόλυτη διεύθυνση URL - οδηγεί σε έναν άλλο ιστότοπο (όπως src='http://www.example.com/movie.ogg') Μια σχετική διεύθυνση URL - οδηγεί σε ένα αρχείο μέσα σε έναν ιστότοπο (όπως src='movie.ogg')"
            '---------- VALUES ----------
            packHTML(108).HTMLIDIOTHTES(8).values(0).onoma = "(pixels)"
            packHTML(108).HTMLIDIOTHTES(8).values(0).ellinika = "(pixels)"
            packHTML(108).HTMLIDIOTHTES(8).values(0).perigrafh = "Το πλάτος του βίντεο, σε pixel (δηλαδή πλάτος = '100')"


#End Region
#Region "<wbr>"
            ReDim packHTML(109).HTMLIDIOTHTES(-1)
            packHTML(109).Etiketa = "<wbr>"
            packHTML(109).onomasia = "διακοπή"
            packHTML(109).ELtrans = "<διακοπή>"
            packHTML(109).Perigrafh = "Ορίζει μια πιθανή διακοπή γραμμής"
            packHTML(109).Syndesmos = ""
#End Region

#Region "TagGlobalAttributes"
            packHTML(2).GlobalAttributes = GlobalAttributes
            packHTML(3).GlobalAttributes = GlobalAttributes
            packHTML(4).GlobalAttributes = GlobalAttributes
            packHTML(5).GlobalAttributes = GlobalAttributes
            packHTML(6).GlobalAttributes = GlobalAttributes
            packHTML(7).GlobalAttributes = GlobalAttributes
            packHTML(8).GlobalAttributes = GlobalAttributes
            packHTML(9).GlobalAttributes = GlobalAttributes
            packHTML(10).GlobalAttributes = GlobalAttributes
            packHTML(11).GlobalAttributes = GlobalAttributes
            packHTML(12).GlobalAttributes = GlobalAttributes
            packHTML(13).GlobalAttributes = GlobalAttributes
            packHTML(14).GlobalAttributes = GlobalAttributes
            packHTML(15).GlobalAttributes = GlobalAttributes
            packHTML(16).GlobalAttributes = GlobalAttributes
            packHTML(17).GlobalAttributes = GlobalAttributes
            packHTML(18).GlobalAttributes = GlobalAttributes
            packHTML(19).GlobalAttributes = GlobalAttributes
            packHTML(20).GlobalAttributes = GlobalAttributes
            packHTML(21).GlobalAttributes = GlobalAttributes
            packHTML(22).GlobalAttributes = GlobalAttributes
            packHTML(23).GlobalAttributes = GlobalAttributes
            packHTML(24).GlobalAttributes = GlobalAttributes
            packHTML(26).GlobalAttributes = GlobalAttributes
            packHTML(27).GlobalAttributes = GlobalAttributes
            packHTML(28).GlobalAttributes = GlobalAttributes
            packHTML(29).GlobalAttributes = GlobalAttributes
            packHTML(30).GlobalAttributes = GlobalAttributes
            packHTML(31).GlobalAttributes = GlobalAttributes
            packHTML(32).GlobalAttributes = GlobalAttributes
            packHTML(33).GlobalAttributes = GlobalAttributes
            packHTML(34).GlobalAttributes = GlobalAttributes
            packHTML(35).GlobalAttributes = GlobalAttributes
            packHTML(36).GlobalAttributes = GlobalAttributes
            packHTML(37).GlobalAttributes = GlobalAttributes
            packHTML(38).GlobalAttributes = GlobalAttributes
            packHTML(39).GlobalAttributes = GlobalAttributes
            packHTML(40).GlobalAttributes = GlobalAttributes
            packHTML(41).GlobalAttributes = GlobalAttributes
            packHTML(42).GlobalAttributes = GlobalAttributes
            packHTML(43).GlobalAttributes = GlobalAttributes
            packHTML(44).GlobalAttributes = GlobalAttributes
            packHTML(45).GlobalAttributes = GlobalAttributes
            packHTML(46).GlobalAttributes = GlobalAttributes
            packHTML(47).GlobalAttributes = GlobalAttributes
            packHTML(48).GlobalAttributes = GlobalAttributes
            packHTML(49).GlobalAttributes = GlobalAttributes
            packHTML(50).GlobalAttributes = GlobalAttributes
            packHTML(51).GlobalAttributes = GlobalAttributes
            packHTML(52).GlobalAttributes = GlobalAttributes
            packHTML(53).GlobalAttributes = GlobalAttributes
            packHTML(54).GlobalAttributes = GlobalAttributes
            packHTML(55).GlobalAttributes = GlobalAttributes
            packHTML(56).GlobalAttributes = GlobalAttributes
            packHTML(57).GlobalAttributes = GlobalAttributes
            packHTML(58).GlobalAttributes = GlobalAttributes
            packHTML(59).GlobalAttributes = GlobalAttributes
            packHTML(60).GlobalAttributes = GlobalAttributes
            packHTML(61).GlobalAttributes = GlobalAttributes
            packHTML(62).GlobalAttributes = GlobalAttributes
            packHTML(63).GlobalAttributes = GlobalAttributes
            packHTML(64).GlobalAttributes = GlobalAttributes
            packHTML(65).GlobalAttributes = GlobalAttributes
            packHTML(66).GlobalAttributes = GlobalAttributes
            packHTML(67).GlobalAttributes = GlobalAttributes
            packHTML(68).GlobalAttributes = GlobalAttributes
            packHTML(69).GlobalAttributes = GlobalAttributes
            packHTML(70).GlobalAttributes = GlobalAttributes
            packHTML(71).GlobalAttributes = GlobalAttributes
            packHTML(72).GlobalAttributes = GlobalAttributes
            packHTML(73).GlobalAttributes = GlobalAttributes
            packHTML(74).GlobalAttributes = GlobalAttributes
            packHTML(75).GlobalAttributes = GlobalAttributes
            packHTML(76).GlobalAttributes = GlobalAttributes
            packHTML(77).GlobalAttributes = GlobalAttributes
            packHTML(78).GlobalAttributes = GlobalAttributes
            packHTML(79).GlobalAttributes = GlobalAttributes
            packHTML(80).GlobalAttributes = GlobalAttributes
            packHTML(81).GlobalAttributes = GlobalAttributes
            packHTML(82).GlobalAttributes = GlobalAttributes
            packHTML(83).GlobalAttributes = GlobalAttributes
            packHTML(84).GlobalAttributes = GlobalAttributes
            packHTML(85).GlobalAttributes = GlobalAttributes
            packHTML(86).GlobalAttributes = GlobalAttributes
            packHTML(87).GlobalAttributes = GlobalAttributes
            packHTML(88).GlobalAttributes = GlobalAttributes
            packHTML(89).GlobalAttributes = GlobalAttributes
            packHTML(90).GlobalAttributes = GlobalAttributes
            packHTML(91).GlobalAttributes = GlobalAttributes
            packHTML(92).GlobalAttributes = GlobalAttributes
            packHTML(93).GlobalAttributes = GlobalAttributes
            packHTML(94).GlobalAttributes = GlobalAttributes
            packHTML(95).GlobalAttributes = GlobalAttributes
            packHTML(96).GlobalAttributes = GlobalAttributes
            packHTML(97).GlobalAttributes = GlobalAttributes
            packHTML(98).GlobalAttributes = GlobalAttributes
            packHTML(99).GlobalAttributes = GlobalAttributes
            packHTML(100).GlobalAttributes = GlobalAttributes
            packHTML(101).GlobalAttributes = GlobalAttributes
            packHTML(102).GlobalAttributes = GlobalAttributes
            packHTML(103).GlobalAttributes = GlobalAttributes
            packHTML(104).GlobalAttributes = GlobalAttributes
            packHTML(105).GlobalAttributes = GlobalAttributes
            packHTML(106).GlobalAttributes = GlobalAttributes
            packHTML(107).GlobalAttributes = GlobalAttributes
            packHTML(108).GlobalAttributes = GlobalAttributes
            packHTML(109).GlobalAttributes = GlobalAttributes
#End Region
#Region "event"
            packHTML(2).Events = Events
            packHTML(3).Events = Events
            packHTML(4).Events = Events
            packHTML(5).Events = Events
            packHTML(6).Events = Events
            packHTML(7).Events = Events
            'packHTML(8).Events = Events
            packHTML(9).Events = Events
            packHTML(10).Events = Events
            packHTML(11).Events = Events
            packHTML(12).Events = Events
            packHTML(13).Events = Events
            'packHTML(14).Events = Events
            packHTML(15).Events = Events
            packHTML(16).Events = Events
            packHTML(17).Events = Events
            packHTML(18).Events = Events
            packHTML(19).Events = Events
            packHTML(20).Events = Events
            packHTML(21).Events = Events
            packHTML(22).Events = Events
            packHTML(23).Events = Events
            packHTML(24).Events = Events
            packHTML(25).Events = Events
            packHTML(26).Events = Events
            'packHTML(27).Events = Events
            packHTML(28).Events = Events
            packHTML(29).Events = Events
            packHTML(30).Events = Events
            packHTML(31).Events = Events
            packHTML(32).Events = Events
            packHTML(33).Events = Events
            packHTML(34).Events = Events
            packHTML(35).Events = Events
            packHTML(36).Events = Events
            packHTML(37).Events = Events
            packHTML(38).Events = Events
            'packHTML(39).Events = Events
            packHTML(40).Events = Events
            packHTML(41).Events = Events
            packHTML(42).Events = Events
            packHTML(43).Events = Events
            packHTML(44).Events = Events
            packHTML(45).Events = Events
            packHTML(46).Events = Events
            packHTML(47).Events = Events
            packHTML(48).Events = Events
            packHTML(49).Events = Events
            packHTML(50).Events = Events
            packHTML(51).Events = Events
            packHTML(52).Events = Events
            'packHTML(53).Events = Events
            packHTML(54).Events = Events
            packHTML(55).Events = Events
            packHTML(56).Events = Events
            packHTML(57).Events = Events
            packHTML(58).Events = Events
            packHTML(59).Events = Events
            packHTML(60).Events = Events
            packHTML(61).Events = Events
            packHTML(62).Events = Events
            packHTML(63).Events = Events
            packHTML(64).Events = Events
            packHTML(65).Events = Events
            packHTML(66).Events = Events
            packHTML(67).Events = Events
            packHTML(68).Events = Events
            packHTML(69).Events = Events
            packHTML(70).Events = Events
            packHTML(71).Events = Events
            packHTML(72).Events = Events
            packHTML(73).Events = Events
            packHTML(74).Events = Events
            packHTML(75).Events = Events
            packHTML(76).Events = Events
            packHTML(77).Events = Events
            packHTML(78).Events = Events
            packHTML(79).Events = Events
            packHTML(80).Events = Events
            packHTML(81).Events = Events
            packHTML(82).Events = Events
            packHTML(83).Events = Events
            packHTML(84).Events = Events
            packHTML(85).Events = Events
            packHTML(86).Events = Events
            packHTML(87).Events = Events
            packHTML(88).Events = Events
            packHTML(89).Events = Events
            packHTML(90).Events = Events
            packHTML(91).Events = Events
            packHTML(92).Events = Events
            packHTML(93).Events = Events
            packHTML(94).Events = Events
            packHTML(95).Events = Events
            packHTML(96).Events = Events
            packHTML(97).Events = Events
            packHTML(98).Events = Events
            packHTML(99).Events = Events
            packHTML(100).Events = Events
            packHTML(101).Events = Events
            packHTML(102).Events = Events
            packHTML(103).Events = Events
            packHTML(104).Events = Events
            packHTML(105).Events = Events
            packHTML(106).Events = Events
            packHTML(107).Events = Events
            'packHTML(108).Events = Events
            packHTML(109).Events = Events
#End Region
        End Sub
    End Class
End Namespace