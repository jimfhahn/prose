using System;
using Microsoft.ProgramSynthesis.Transformation.Json;
using Microsoft.ProgramSynthesis.Wrangling.Constraints;
using Newtonsoft.Json.Linq;

namespace Transformation.Json
{
    internal static partial class Sample
    {
        /// <summary>
        ///    Illustrates PROSE JSON To JSON capability.
        /// </summary>
        internal static void JsonToJsonSample()
        {
            // The original input file (which can be very large).
            // https://id.loc.gov/resources/works/20813223.json
            JToken input = JToken.Parse(@"[
{
"@id": "_:b193iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Contribution"
],
"http://id.loc.gov/ontologies/bibframe/agent": [
{
"@id": "http://id.loc.gov/rwo/agents/n87831130"
}
],
"http://id.loc.gov/ontologies/bibframe/role": [
{
"@id": "http://id.loc.gov/vocabulary/relators/dte"
},
{
"@id": "http://id.loc.gov/vocabulary/relators/dte"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/relators/dte",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Role",
"http://id.loc.gov/ontologies/bibframe/Role"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Dedicatee."
},
{
"@value": "Dedicatee"
}
]
},
{
"@id": "_:b61iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/TableOfContents"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Introduction / by Nicholas J. Healy, Jr., and Matthew Levering -- 1 Father Joseph Fessio, S.J.: A personal memoir / David L. Schindler -- 2 The mystical body in the 'nouvelle théologie' / David Vincent Meconi, S.J. -- 3 'Mysterium fidei:' On tradition, liturgy, and being at the service of the church / Aaron Riches -- 4 The Ratzinger option: introducing Christianity in a postmodern age / Michael Dauphinais -- 5 Hans Urs von Balthasar and his path to Reinhold Schneider / Peter Csarella -- 6 From classic to patristic: Von Balthasar, Rahner, and the origins of analogy / Stephen M. Fields, S.J. -- 7 Reading the mystery of God: The Ignatian roots of Henri de Lubac's understanding of scripture / Joseph S. Flipper -- 8 Marriage as an Image of the Trinity / Matthew Levering -- 9 What does Hans Urs von Balthasar mean by drama? / Francesca Aran Murphy -- 10 The theological mind and method of Pope Benedict XVI as revealed in his catechetical instructions / Matthew J. Ramage -- 11 Taking truth for granted: A reflection on the significance of tradition in Josef Pieper / D. C. Schindler -- 12 Theological aesthetics as method / Anne M. Carpenter -- 13 Henri de Lubac on the development of doctrine / Nicholas J. Healy, Jr. -- About the contributors -- Subject index -- Index of names."
}
]
},
{
"@id": "http://id.loc.gov/resources/hubs/62bda623e626b794ca1f67093efdb2fc",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Work",
"http://www.loc.gov/mads/rdf/v1#"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Bible."
}
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Bible."
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "bible"
}
],
"http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme": [
{
"@id": "http://id.loc.gov/vocabulary/subjectSchemes/fast"
}
],
"http://id.loc.gov/ontologies/bibframe/title": [
{
"@id": "_:b158iddOtlocdOtgovresourcesworks20813223"
}
]
},
{
"@id": "_:b187iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Source"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "OCoLC"
}
]
},
{
"@id": "_:b111iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://www.loc.gov/mads/rdf/v1#Topic"
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Criticism and interpretation"
}
]
},
{
"@id": "_:b174iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/GenreForm",
"http://www.loc.gov/mads/rdf/v1#Topic"
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Criticism, interpretation, etc."
}
],
"http://id.loc.gov/ontologies/bibframe/source": [
{
"@id": "http://id.loc.gov/vocabulary/genreFormSchemes/fast"
}
],
"http://id.loc.gov/ontologies/bibframe/identifiedBy": [
{
"@id": "_:b183iddOtlocdOtgovresourcesworks20813223"
}
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Criticism, interpretation, etc."
}
]
},
{
"@id": "_:b268iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/VariantTitle"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Ressourcement after Vatican 2"
}
],
"http://id.loc.gov/ontologies/bibframe/mainTitle": [
{
"@value": "Ressourcement after Vatican 2"
}
]
},
{
"@id": "_:b33iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Source"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "23"
}
]
},
{
"@id": "_:b99iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Title"
],
"http://id.loc.gov/ontologies/bflc/title30MatchKey": [
{
"@value": "Bible"
}
],
"http://id.loc.gov/ontologies/bflc/title30MarcKey": [
{
"@value": "63000$aBible$xCriticism and interpretation."
}
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Bible"
}
],
"http://id.loc.gov/ontologies/bflc/titleSortKey": [
{
"@value": "Bible"
}
],
"http://id.loc.gov/ontologies/bibframe/mainTitle": [
{
"@value": "Bible"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/organizations/dlc",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Agent"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "DLC"
},
{
"@value": "DLC"
}
]
},
{
"@id": "_:b282iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/AdminMetadata"
],
"http://id.loc.gov/ontologies/bibframe/generationProcess": [
{
"@id": "_:b284iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/status": [
{
"@id": "_:b290iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bflc/encodingLevel": [
{
"@id": "http://id.loc.gov/vocabulary/menclvl/7"
}
],
"http://id.loc.gov/ontologies/bibframe/descriptionConventions": [
{
"@id": "http://id.loc.gov/vocabulary/descriptionConventions/isbd"
},
{
"@id": "http://id.loc.gov/vocabulary/descriptionConventions/rda"
}
],
"http://id.loc.gov/ontologies/bibframe/identifiedBy": [
{
"@id": "_:b304iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/changeDate": [
{
"@type": "http://www.w3.org/2001/XMLSchema#dateTime",
"@value": "2021-04-20T13:16:12"
}
],
"http://id.loc.gov/ontologies/bibframe/creationDate": [
{
"@type": "http://www.w3.org/2001/XMLSchema#date",
"@value": "2019-01-17"
}
],
"http://id.loc.gov/ontologies/lclocal/d906": [
{
"@value": "=906     $a 7 $b cbc $c copycat $d 2 $e ncip $f 20 $g y-gencatlg"
}
],
"http://id.loc.gov/ontologies/lclocal/d925": [
{
"@value": "=925  0  $a acquire $b 1 shelf copy $x policy default"
}
],
"http://id.loc.gov/ontologies/lclocal/d955": [
{
"@value": "=955     $b rk01 2020-11-27 z-processor $i rk01 2020-11-27 TW Situational to PSD"
},
{
"@value": "=955     $a pc28 2019-01-17"
}
],
"http://id.loc.gov/ontologies/bibframe/assigner": [
{
"@id": "_:b324iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/descriptionLanguage": [
{
"@id": "http://id.loc.gov/vocabulary/languages/eng"
}
],
"http://id.loc.gov/ontologies/bibframe/descriptionModifier": [
{
"@id": "http://id.loc.gov/vocabulary/organizations/dlc"
}
],
"http://id.loc.gov/ontologies/bibframe/descriptionAuthentication": [
{
"@id": "http://id.loc.gov/vocabulary/marcauthen/lccopycat"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/descriptionConventions/rda",
"@type": [
"http://id.loc.gov/ontologies/bibframe/DescriptionConventions"
],
"http://www.w3.org/1999/02/22-rdf-syntax-ns#value": [
{
"@value": "rda"
}
]
},
{
"@id": "_:b29iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/ClassificationDdc"
],
"http://id.loc.gov/ontologies/bibframe/classificationPortion": [
{
"@value": "282"
}
],
"http://id.loc.gov/ontologies/bibframe/source": [
{
"@id": "_:b33iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/edition": [
{
"@value": "full"
}
]
},
{
"@id": "http://id.loc.gov/resources/REPLACE/20813223#Work630-31",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Work",
"http://www.loc.gov/mads/rdf/v1#"
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Bible"
}
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Bible"
}
],
"http://id.loc.gov/ontologies/bibframe/title": [
{
"@id": "_:b99iddOtlocdOtgovresourcesworks20813223"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/languages/eng",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Language",
"http://id.loc.gov/ontologies/bibframe/Language"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "English"
},
{
"@value": "English"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/descriptionConventions/isbd",
"@type": [
"http://id.loc.gov/ontologies/bibframe/DescriptionConventions"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "isbd"
}
]
},
{
"@id": "http://id.loc.gov/rwo/agents/n2002092950",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Person"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Levering, Matthew, 1971-"
}
],
"http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority": [
{
"@id": "http://id.loc.gov/authorities/names/n2002092950"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/msupplcont/index",
"@type": [
"http://id.loc.gov/ontologies/bibframe/SupplementaryContent"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "index"
}
]
},
{
"@id": "_:b41iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Title"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J."
}
],
"http://id.loc.gov/ontologies/bibframe/mainTitle": [
{
"@value": "Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J."
}
]
},
{
"@id": "_:b284iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/GenerationProcess"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "DLC marc2bibframe2 v1.7.0-SNAPSHOT"
}
],
"http://id.loc.gov/ontologies/bibframe/generationDate": [
{
"@type": "http://www.w3.org/2001/XMLSchema#dateTime",
"@value": "2021-08-09T15:07:50.808634-04:00"
}
]
},
{
"@id": "_:b274iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/VariantTitle"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Ressourcement after Vatican Two"
}
],
"http://id.loc.gov/ontologies/bibframe/mainTitle": [
{
"@value": "Ressourcement after Vatican Two"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/menclvl/7",
"@type": [
"http://id.loc.gov/ontologies/bflc/EncodingLevel"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "minimal"
}
]
},
{
"@id": "_:b324iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "DDC"
}
]
},
{
"@id": "http://id.loc.gov/resources/works/20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Work",
"http://id.loc.gov/ontologies/bibframe/Text"
],
"http://id.loc.gov/ontologies/bflc/aap": [
{
"@value": "Fessio, Joseph, Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J"
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "fessiojosephressourcementaftervaticanii:essaysinhonorofjosephfessiosj"
}
],
"http://id.loc.gov/ontologies/bibframe/language": [
{
"@id": "http://id.loc.gov/vocabulary/languages/eng"
}
],
"http://id.loc.gov/ontologies/bibframe/genreForm": [
{
"@id": "http://id.loc.gov/authorities/genreForms/gf2016026082"
},
{
"@id": "_:b174iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/supplementaryContent": [
{
"@id": "http://id.loc.gov/vocabulary/msupplcont/index"
},
{
"@id": "_:b53iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/classification": [
{
"@id": "_:b21iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b29iddOtlocdOtgovresourcesworks20813223"
}
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J."
}
],
"http://id.loc.gov/ontologies/bibframe/title": [
{
"@id": "_:b41iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/content": [
{
"@id": "http://id.loc.gov/vocabulary/contentTypes/txt"
}
],
"http://id.loc.gov/ontologies/bibframe/summary": [
{
"@id": "_:b57iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/tableOfContents": [
{
"@id": "_:b61iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/subject": [
{
"@id": "http://id.loc.gov/rwo/agents/n79041716"
},
{
"@id": "http://id.loc.gov/rwo/agents/n79084169"
},
{
"@id": "_:b87iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "http://id.loc.gov/authorities/subjects/sh85077732"
},
{
"@id": "http://id.loc.gov/rwo/agents/n79041716"
},
{
"@id": "_:b137iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "http://id.loc.gov/resources/hubs/62bda623e626b794ca1f67093efdb2fc"
},
{
"@id": "http://id.loc.gov/authorities/subjects/sh85077732"
}
],
"http://id.loc.gov/ontologies/bibframe/contribution": [
{
"@id": "_:b193iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b209iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b225iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b241iddOtlocdOtgovresourcesworks20813223"
}
],
"http://purl.org/dc/terms/isPartOf": [
{
"@id": "http://id.loc.gov/resources/works"
}
],
"http://id.loc.gov/ontologies/bibframe/hasInstance": [
{
"@id": "http://id.loc.gov/resources/instances/20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/adminMetadata": [
{
"@id": "_:b282iddOtlocdOtgovresourcesworks20813223"
}
]
},
{
"@id": "_:b21iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/ClassificationLcc"
],
"http://id.loc.gov/ontologies/bibframe/assigner": [
{
"@id": "http://id.loc.gov/vocabulary/organizations/dlc"
}
],
"http://id.loc.gov/ontologies/bibframe/classificationPortion": [
{
"@value": "BX880"
}
],
"http://id.loc.gov/ontologies/bibframe/itemPortion": [
{
"@value": ".R46 2019"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/contentTypes/txt",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Content"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "text"
}
],
"http://id.loc.gov/ontologies/bibframe/source": [
{
"@id": "http://id.loc.gov/vocabulary/genreFormSchemes/rdacontent"
}
]
},
{
"@id": "http://id.loc.gov/rwo/agents/n87831130",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Person"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Fessio, Joseph,"
}
],
"http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority": [
{
"@id": "http://id.loc.gov/authorities/names/n87831130"
}
]
},
{
"@id": "_:b225iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Contribution"
],
"http://id.loc.gov/ontologies/bibframe/agent": [
{
"@id": "http://id.loc.gov/rwo/agents/no2006017648"
}
],
"http://id.loc.gov/ontologies/bibframe/role": [
{
"@id": "http://id.loc.gov/vocabulary/relators/edt"
},
{
"@id": "http://id.loc.gov/vocabulary/relators/edt"
}
]
},
{
"@id": "http://id.loc.gov/resources/instances/20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Instance"
],
"http://id.loc.gov/ontologies/bibframe/title": [
{
"@id": "_:b260iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b268iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b274iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/provisionActivityStatement": [
{
"@value": "San Francisco : Ignatius Press, [2019]"
}
]
},
{
"@id": "http://id.loc.gov/rwo/agents/n2002105719",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Organization"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Ignatius Press,"
}
],
"http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority": [
{
"@id": "http://id.loc.gov/authorities/names/n2002105719"
}
]
},
{
"@id": "_:b260iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Title"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J."
}
],
"http://id.loc.gov/ontologies/bibframe/mainTitle": [
{
"@value": "Ressourcement after Vatican II"
}
],
"http://id.loc.gov/ontologies/bibframe/subtitle": [
{
"@value": "essays in honor of Joseph Fessio, S.J"
}
]
},
{
"@id": "_:b290iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Status"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "corrected or revised"
}
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "c"
}
]
},
{
"@id": "_:b241iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Contribution"
],
"http://id.loc.gov/ontologies/bibframe/agent": [
{
"@id": "http://id.loc.gov/rwo/agents/n2002105719"
}
],
"http://id.loc.gov/ontologies/bibframe/role": [
{
"@id": "http://id.loc.gov/vocabulary/relators/pbl"
},
{
"@id": "http://id.loc.gov/vocabulary/relators/pbl"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/marcauthen/lccopycat",
"@type": [
"http://id.loc.gov/ontologies/bibframe/DescriptionAuthentication"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "lccopycat"
}
]
},
{
"@id": "_:b87iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Topic",
"http://www.loc.gov/mads/rdf/v1#ComplexSubject"
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Bible--Criticism and interpretation."
}
],
"http://www.loc.gov/mads/rdf/v1#componentList": [
{
"@list": [
{
"@id": "http://id.loc.gov/resources/REPLACE/20813223#Work630-31"
},
{
"@id": "_:b111iddOtlocdOtgovresourcesworks20813223"
}
]
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "biblecriticismandinterpretation"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/relators/edt",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Role",
"http://id.loc.gov/ontologies/bibframe/Role",
"http://id.loc.gov/ontologies/bibframe/Role",
"http://id.loc.gov/ontologies/bibframe/Role"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "editor."
},
{
"@value": "Editor"
},
{
"@value": "editor."
},
{
"@value": "Editor"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/genreFormSchemes/fast",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Source"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "fast"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/relators/pbl",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Role",
"http://id.loc.gov/ontologies/bibframe/Role"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "publisher."
},
{
"@value": "Publisher"
}
]
},
{
"@id": "_:b53iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/SupplementaryContent"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Includes bibliographical references and indexes."
}
]
},
{
"@id": "_:b183iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Identifier"
],
"http://www.w3.org/1999/02/22-rdf-syntax-ns#value": [
{
"@value": "fst01411635"
}
],
"http://id.loc.gov/ontologies/bibframe/source": [
{
"@id": "_:b187iddOtlocdOtgovresourcesworks20813223"
}
]
},
{
"@id": "_:b209iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Contribution"
],
"http://id.loc.gov/ontologies/bibframe/agent": [
{
"@id": "http://id.loc.gov/rwo/agents/n2002092950"
}
],
"http://id.loc.gov/ontologies/bibframe/role": [
{
"@id": "http://id.loc.gov/vocabulary/relators/edt"
},
{
"@id": "http://id.loc.gov/vocabulary/relators/edt"
}
]
},
{
"@id": "http://id.loc.gov/rwo/agents/no2006017648",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Person"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Healy, Nicholas J., Jr. (Nicholas John),"
}
],
"http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority": [
{
"@id": "http://id.loc.gov/authorities/names/no2006017648"
}
]
},
{
"@id": "_:b158iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Title"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Bible."
}
],
"http://id.loc.gov/ontologies/bibframe/mainTitle": [
{
"@value": "Bible"
}
]
},
{
"@id": "http://id.loc.gov/authorities/subjects/sh85077732",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Topic",
"http://www.loc.gov/mads/rdf/v1#Topic",
"http://id.loc.gov/ontologies/bibframe/Topic",
"http://www.loc.gov/mads/rdf/v1#Topic"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Liturgics."
},
{
"@value": "Liturgics."
}
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Liturgics."
},
{
"@value": "Liturgics."
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "liturgics"
},
{
"@value": "liturgics"
}
],
"http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme": [
{
"@id": "http://id.loc.gov/vocabulary/subjectSchemes/fast"
}
]
},
{
"@id": "_:b137iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Meeting",
"http://www.loc.gov/mads/rdf/v1#ConferenceName"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Vatican Council."
}
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Vatican Council."
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "vaticancouncil"
}
],
"http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme": [
{
"@id": "http://id.loc.gov/vocabulary/subjectSchemes/fast"
}
]
},
{
"@id": "http://id.loc.gov/authorities/genreForms/gf2016026082",
"@type": [
"http://id.loc.gov/ontologies/bibframe/GenreForm"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "festschriften"
}
]
},
{
"@id": "_:b57iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Summary"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "\"Beginning with a personal recollection of the achievements of Father Joseph Fessio, S.J., this work includes twelve essays by theologians who acknowledge a dept to Father Fessio and Ignatius Press. The writers treat a variety of topics including the Church, the liturgy, the interpretation of Scripture, and the development of doctrine, representing the interests of Father Fessio and the books that he published. The essays touch upon the major twentieth-century figures who influenced Father Fessio, such as Hans Urs von Balthasar, Louis Bouyer, Henri de Lubac, Joseph Ratzinger, and Josef Pieper. From its founding by Father Fessio in 1978, Ignatius Press has translated and printed works by these great thinkers and writers in order to make their contributions to the Church available to English-speaking Catholics.\"-- Provided by publisher, page 4 of cover."
}
]
},
{
"@id": "http://id.loc.gov/rwo/agents/n79084169",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Meeting",
"http://www.loc.gov/mads/rdf/v1#ConferenceName"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Vatican Council (2nd : 1962-1965 : Basilica di San Pietro in Vaticano)"
}
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Vatican Council (2nd : 1962-1965 : Basilica di San Pietro in Vaticano)"
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "vaticancouncil(2nd:19621965:basilicadisanpietroinvaticano)"
}
],
"http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority": [
{
"@id": "http://id.loc.gov/authorities/names/n79084169"
}
]
},
{
"@id": "_:b304iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Local"
],
"http://www.w3.org/1999/02/22-rdf-syntax-ns#value": [
{
"@value": "20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/assigner": [
{
"@id": "http://id.loc.gov/vocabulary/organizations/dlc"
}
]
},
{
"@id": "http://id.loc.gov/vocabulary/genreFormSchemes/rdacontent",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Source"
]
},
{
"@id": "http://id.loc.gov/rwo/agents/n79041716",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Organization",
"http://www.loc.gov/mads/rdf/v1#CorporateName",
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Organization",
"http://www.loc.gov/mads/rdf/v1#CorporateName"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Catholic Church."
},
{
"@value": "Catholic Church."
}
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Catholic Church."
},
{
"@value": "Catholic Church."
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "catholicchurch"
},
{
"@value": "catholicchurch"
}
],
"http://www.loc.gov/mads/rdf/v1#isIdentifiedByAuthority": [
{
"@id": "http://id.loc.gov/authorities/names/n79041716"
},
{
"@id": "http://id.loc.gov/authorities/names/n79041716"
}
],
"http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme": [
{
"@id": "http://id.loc.gov/vocabulary/subjectSchemes/fast"
}
]
}
]");
            // The training input file, which is a small prefix of the input file.
            //https://id.loc.gov/resources/works/20813223.bibframe.json
            JToken trainInput = JToken.Parse(@"[
{
"@id": "_:b121iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Status"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "corrected or revised"
}
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "c"
}
]
},
{
"@id": "_:b23iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Source"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "23"
}
]
},
{
"@id": "_:b115iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/GenerationProcess"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "DLC marc2bibframe2 v1.7.0-SNAPSHOT"
}
],
"http://id.loc.gov/ontologies/bibframe/generationDate": [
{
"@type": "http://www.w3.org/2001/XMLSchema#dateTime",
"@value": "2021-08-09T15:07:50.808634-04:00"
}
]
},
{
"@id": "_:b81iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Identifier"
],
"http://www.w3.org/1999/02/22-rdf-syntax-ns#value": [
{
"@value": "fst01411635"
}
],
"http://id.loc.gov/ontologies/bibframe/source": [
{
"@id": "_:b85iddOtlocdOtgovresourcesworks20813223"
}
]
},
{
"@id": "_:b129iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Local"
],
"http://www.w3.org/1999/02/22-rdf-syntax-ns#value": [
{
"@value": "20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/assigner": [
{
"@id": "http://id.loc.gov/vocabulary/organizations/dlc"
}
]
},
{
"@id": "_:b12iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/ClassificationLcc"
],
"http://id.loc.gov/ontologies/bibframe/assigner": [
{
"@id": "http://id.loc.gov/vocabulary/organizations/dlc"
}
],
"http://id.loc.gov/ontologies/bibframe/classificationPortion": [
{
"@value": "BX880"
}
],
"http://id.loc.gov/ontologies/bibframe/itemPortion": [
{
"@value": ".R46 2019"
}
]
},
{
"@id": "_:b19iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/ClassificationDdc"
],
"http://id.loc.gov/ontologies/bibframe/classificationPortion": [
{
"@value": "282"
}
],
"http://id.loc.gov/ontologies/bibframe/source": [
{
"@id": "_:b23iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/edition": [
{
"@value": "full"
}
]
},
{
"@id": "_:b62iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent",
"http://id.loc.gov/ontologies/bibframe/Meeting",
"http://www.loc.gov/mads/rdf/v1#ConferenceName"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Vatican Council."
}
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Vatican Council."
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "vaticancouncil"
}
],
"http://www.loc.gov/mads/rdf/v1#isMemberOfMADSScheme": [
{
"@id": "http://id.loc.gov/vocabulary/subjectSchemes/fast"
}
]
},
{
"@id": "http://id.loc.gov/resources/works/20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Work",
"http://id.loc.gov/ontologies/bibframe/Text"
],
"http://id.loc.gov/ontologies/bflc/aap": [
{
"@value": "Fessio, Joseph, Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J"
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "fessiojosephressourcementaftervaticanii:essaysinhonorofjosephfessiosj"
}
],
"http://id.loc.gov/ontologies/bibframe/language": [
{
"@id": "http://id.loc.gov/vocabulary/languages/eng"
}
],
"http://id.loc.gov/ontologies/bibframe/genreForm": [
{
"@id": "http://id.loc.gov/authorities/genreForms/gf2016026082"
},
{
"@id": "_:b75iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/supplementaryContent": [
{
"@id": "http://id.loc.gov/vocabulary/msupplcont/index"
},
{
"@id": "_:b38iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/classification": [
{
"@id": "_:b12iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b19iddOtlocdOtgovresourcesworks20813223"
}
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J."
}
],
"http://id.loc.gov/ontologies/bibframe/title": [
{
"@id": "_:b31iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/content": [
{
"@id": "http://id.loc.gov/vocabulary/contentTypes/txt"
}
],
"http://id.loc.gov/ontologies/bibframe/summary": [
{
"@id": "_:b42iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/tableOfContents": [
{
"@id": "_:b46iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/subject": [
{
"@id": "http://id.loc.gov/rwo/agents/n79041716"
},
{
"@id": "http://id.loc.gov/rwo/agents/n79084169"
},
{
"@id": "_:b52iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "http://id.loc.gov/authorities/subjects/sh85077732"
},
{
"@id": "http://id.loc.gov/rwo/agents/n79041716"
},
{
"@id": "_:b62iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "http://id.loc.gov/resources/hubs/62bda623e626b794ca1f67093efdb2fc"
},
{
"@id": "http://id.loc.gov/authorities/subjects/sh85077732"
}
],
"http://id.loc.gov/ontologies/bibframe/contribution": [
{
"@id": "_:b91iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b96iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b101iddOtlocdOtgovresourcesworks20813223"
},
{
"@id": "_:b106iddOtlocdOtgovresourcesworks20813223"
}
],
"http://purl.org/dc/terms/isPartOf": [
{
"@id": "http://id.loc.gov/resources/works"
}
],
"http://id.loc.gov/ontologies/bibframe/hasInstance": [
{
"@id": "http://id.loc.gov/resources/instances/20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/adminMetadata": [
{
"@id": "_:b113iddOtlocdOtgovresourcesworks20813223"
}
]
},
{
"@id": "_:b42iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Summary"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "\"Beginning with a personal recollection of the achievements of Father Joseph Fessio, S.J., this work includes twelve essays by theologians who acknowledge a dept to Father Fessio and Ignatius Press. The writers treat a variety of topics including the Church, the liturgy, the interpretation of Scripture, and the development of doctrine, representing the interests of Father Fessio and the books that he published. The essays touch upon the major twentieth-century figures who influenced Father Fessio, such as Hans Urs von Balthasar, Louis Bouyer, Henri de Lubac, Joseph Ratzinger, and Josef Pieper. From its founding by Father Fessio in 1978, Ignatius Press has translated and printed works by these great thinkers and writers in order to make their contributions to the Church available to English-speaking Catholics.\"-- Provided by publisher, page 4 of cover."
}
]
},
{
"@id": "_:b31iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Title"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J."
}
],
"http://id.loc.gov/ontologies/bibframe/mainTitle": [
{
"@value": "Ressourcement after Vatican II : essays in honor of Joseph Fessio, S.J."
}
]
},
{
"@id": "_:b38iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/SupplementaryContent"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Includes bibliographical references and indexes."
}
]
},
{
"@id": "_:b85iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Source"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "OCoLC"
}
]
},
{
"@id": "_:b91iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Contribution"
],
"http://id.loc.gov/ontologies/bibframe/agent": [
{
"@id": "http://id.loc.gov/rwo/agents/n87831130"
}
],
"http://id.loc.gov/ontologies/bibframe/role": [
{
"@id": "http://id.loc.gov/vocabulary/relators/dte"
},
{
"@id": "http://id.loc.gov/vocabulary/relators/dte"
}
]
},
{
"@id": "_:b101iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Contribution"
],
"http://id.loc.gov/ontologies/bibframe/agent": [
{
"@id": "http://id.loc.gov/rwo/agents/no2006017648"
}
],
"http://id.loc.gov/ontologies/bibframe/role": [
{
"@id": "http://id.loc.gov/vocabulary/relators/edt"
},
{
"@id": "http://id.loc.gov/vocabulary/relators/edt"
}
]
},
{
"@id": "_:b146iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Agent"
],
"http://id.loc.gov/ontologies/bibframe/code": [
{
"@value": "DDC"
}
]
},
{
"@id": "_:b75iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/GenreForm",
"http://www.loc.gov/mads/rdf/v1#Topic"
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Criticism, interpretation, etc."
}
],
"http://id.loc.gov/ontologies/bibframe/source": [
{
"@id": "http://id.loc.gov/vocabulary/genreFormSchemes/fast"
}
],
"http://id.loc.gov/ontologies/bibframe/identifiedBy": [
{
"@id": "_:b81iddOtlocdOtgovresourcesworks20813223"
}
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Criticism, interpretation, etc."
}
]
},
{
"@id": "_:b96iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Contribution"
],
"http://id.loc.gov/ontologies/bibframe/agent": [
{
"@id": "http://id.loc.gov/rwo/agents/n2002092950"
}
],
"http://id.loc.gov/ontologies/bibframe/role": [
{
"@id": "http://id.loc.gov/vocabulary/relators/edt"
},
{
"@id": "http://id.loc.gov/vocabulary/relators/edt"
}
]
},
{
"@id": "_:b113iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/AdminMetadata"
],
"http://id.loc.gov/ontologies/bibframe/generationProcess": [
{
"@id": "_:b115iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/status": [
{
"@id": "_:b121iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bflc/encodingLevel": [
{
"@id": "http://id.loc.gov/vocabulary/menclvl/7"
}
],
"http://id.loc.gov/ontologies/bibframe/descriptionConventions": [
{
"@id": "http://id.loc.gov/vocabulary/descriptionConventions/isbd"
},
{
"@id": "http://id.loc.gov/vocabulary/descriptionConventions/rda"
}
],
"http://id.loc.gov/ontologies/bibframe/identifiedBy": [
{
"@id": "_:b129iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/changeDate": [
{
"@type": "http://www.w3.org/2001/XMLSchema#dateTime",
"@value": "2021-04-20T13:16:12"
}
],
"http://id.loc.gov/ontologies/bibframe/creationDate": [
{
"@type": "http://www.w3.org/2001/XMLSchema#date",
"@value": "2019-01-17"
}
],
"http://id.loc.gov/ontologies/lclocal/d906": [
{
"@value": "=906     $a 7 $b cbc $c copycat $d 2 $e ncip $f 20 $g y-gencatlg"
}
],
"http://id.loc.gov/ontologies/lclocal/d925": [
{
"@value": "=925  0  $a acquire $b 1 shelf copy $x policy default"
}
],
"http://id.loc.gov/ontologies/lclocal/d955": [
{
"@value": "=955     $b rk01 2020-11-27 z-processor $i rk01 2020-11-27 TW Situational to PSD"
},
{
"@value": "=955     $a pc28 2019-01-17"
}
],
"http://id.loc.gov/ontologies/bibframe/assigner": [
{
"@id": "_:b146iddOtlocdOtgovresourcesworks20813223"
}
],
"http://id.loc.gov/ontologies/bibframe/descriptionLanguage": [
{
"@id": "http://id.loc.gov/vocabulary/languages/eng"
}
],
"http://id.loc.gov/ontologies/bibframe/descriptionModifier": [
{
"@id": "http://id.loc.gov/vocabulary/organizations/dlc"
}
],
"http://id.loc.gov/ontologies/bibframe/descriptionAuthentication": [
{
"@id": "http://id.loc.gov/vocabulary/marcauthen/lccopycat"
}
]
},
{
"@id": "_:b106iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Contribution"
],
"http://id.loc.gov/ontologies/bibframe/agent": [
{
"@id": "http://id.loc.gov/rwo/agents/n2002105719"
}
],
"http://id.loc.gov/ontologies/bibframe/role": [
{
"@id": "http://id.loc.gov/vocabulary/relators/pbl"
},
{
"@id": "http://id.loc.gov/vocabulary/relators/pbl"
}
]
},
{
"@id": "_:b52iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/Topic",
"http://www.loc.gov/mads/rdf/v1#ComplexSubject"
],
"http://www.loc.gov/mads/rdf/v1#authoritativeLabel": [
{
"@value": "Bible--Criticism and interpretation."
}
],
"http://www.loc.gov/mads/rdf/v1#componentList": [
{
"@id": "http://id.loc.gov/resources/REPLACE/20813223#Work630-31"
}
],
"http://id.loc.gov/ontologies/bflc/aap-normalized": [
{
"@value": "biblecriticismandinterpretation"
}
]
},
{
"@id": "_:b46iddOtlocdOtgovresourcesworks20813223",
"@type": [
"http://id.loc.gov/ontologies/bibframe/TableOfContents"
],
"http://www.w3.org/2000/01/rdf-schema#label": [
{
"@value": "Introduction / by Nicholas J. Healy, Jr., and Matthew Levering -- 1 Father Joseph Fessio, S.J.: A personal memoir / David L. Schindler -- 2 The mystical body in the 'nouvelle théologie' / David Vincent Meconi, S.J. -- 3 'Mysterium fidei:' On tradition, liturgy, and being at the service of the church / Aaron Riches -- 4 The Ratzinger option: introducing Christianity in a postmodern age / Michael Dauphinais -- 5 Hans Urs von Balthasar and his path to Reinhold Schneider / Peter Csarella -- 6 From classic to patristic: Von Balthasar, Rahner, and the origins of analogy / Stephen M. Fields, S.J. -- 7 Reading the mystery of God: The Ignatian roots of Henri de Lubac's understanding of scripture / Joseph S. Flipper -- 8 Marriage as an Image of the Trinity / Matthew Levering -- 9 What does Hans Urs von Balthasar mean by drama? / Francesca Aran Murphy -- 10 The theological mind and method of Pope Benedict XVI as revealed in his catechetical instructions / Matthew J. Ramage -- 11 Taking truth for granted: A reflection on the significance of tradition in Josef Pieper / D. C. Schindler -- 12 Theological aesthetics as method / Anne M. Carpenter -- 13 Henri de Lubac on the development of doctrine / Nicholas J. Healy, Jr. -- About the contributors -- Subject index -- Index of names."
}
]
}
]");

            // The training output file, which is the desired output for the training input.
            // https://api.sinopia.io/resource/6c59b6f6-6bef-4c1b-a771-dda011f600ed
                                             
            JToken trainOutput = JToken.Parse(@"
{
  "data": [
    {
      "@id": "_:b0",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Contribution"
      ],
      "http://id.loc.gov/ontologies/bibframe/agent": [
        {
          "@id": "_:b1"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/role": [
        {
          "@id": "http://id.loc.gov/vocabulary/relators/edt"
        }
      ]
    },
    {
      "@id": "_:b1",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Person"
      ],
      "http://www.w3.org/1999/02/22-rdf-syntax-ns#value": [
        {
          "@id": "http://id.loc.gov/authorities/names/no2006017648"
        }
      ]
    },
    {
      "@id": "_:b10",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Person"
      ],
      "http://www.w3.org/1999/02/22-rdf-syntax-ns#value": [
        {
          "@id": "http://id.loc.gov/authorities/names/n2002092950"
        }
      ]
    },
    {
      "@id": "_:b11",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/SupplementaryContent"
      ],
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Includes bibliographical references and index.",
          "@language": "eng"
        }
      ]
    },
    {
      "@id": "_:b12",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/TableOfContents"
      ],
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Introduction / Nicholas J. Healy Jr., Matthew Levering -- Father Joseph Fessio, S.J. : a personal memoir / David L. Schindler -- The mystical body in the nouvelle théologie / David Vincent Meconi, S.J. -- Mysterium fides : on tradition, liturgy and being at the service of the church / Aaron Riches -- The Ratzinger option : introduction Christianity in a postmodern age / Michael Dauphinais -- Hans Urs von Balthasar and his path to Reinhold Schneider / Peter Casarella -- From classic to patristic : Von Balthasar, Rahner, and the origins of analogy / Stephen M. Fields, S.J. -- Reading the mystery of God : the Ignatian roots of Henri de Lbac's understanding of Scripture / Joseph S. Flipper -- Marriage as an image of the Trinity / Matthew Levering -- What does Hans Urs von Balthasar mean by drama? / Francesca Aran Murphy -- The theological mind and method of Pope Benedict XVI as revealed in his catechetical instruction / Matthew J. Ramage -- Taking truth for granted : a reflection on the significance of tradition in Josef Pieper / D.C. Schindler -- Theological aesthetics as method / Anne M. Carpenter -- Henri de Lubac on the development of doctrine / Nichlas J. Healy, Jr.",
          "@language": "eng"
        }
      ]
    },
    {
      "@id": "_:b13",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Script"
      ],
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Latin",
          "@language": "eng"
        }
      ]
    },
    {
      "@id": "_:b2",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/GenreForm"
      ],
      "http://id.loc.gov/ontologies/bibframe/GenreForm": [
        {
          "@id": "http://id.loc.gov/authorities/genreForms/gf2016026082"
        }
      ]
    },
    {
      "@id": "_:b3",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/ClassificationLcc"
      ],
      "http://id.loc.gov/ontologies/bibframe/classificationPortion": [
        {
          "@value": "BX1747"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/itemPortion": [
        {
          "@value": ".R485 2019"
        }
      ]
    },
    {
      "@id": "_:b4",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Title"
      ],
      "http://id.loc.gov/ontologies/bibframe/mainTitle": [
        {
          "@value": "Ressourcement after Vatican II",
          "@language": "eng"
        }
      ]
    },
    {
      "@id": "_:b5",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/GenreForm"
      ],
      "http://id.loc.gov/ontologies/bibframe/GenreForm": [
        {
          "@id": "http://id.loc.gov/authorities/genreForms/gf2014026094"
        }
      ]
    },
    {
      "@id": "_:b6",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Contribution"
      ],
      "http://id.loc.gov/ontologies/bibframe/agent": [
        {
          "@id": "_:b7"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/role": [
        {
          "@id": "http://id.loc.gov/vocabulary/relators/hnr"
        }
      ]
    },
    {
      "@id": "_:b7",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Person"
      ],
      "http://www.w3.org/1999/02/22-rdf-syntax-ns#value": [
        {
          "@id": "http://id.loc.gov/authorities/names/n87831130"
        }
      ]
    },
    {
      "@id": "_:b8",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/VariantTitle"
      ],
      "http://id.loc.gov/ontologies/bibframe/mainTitle": [
        {
          "@value": "Ressourcement after Vatican Two",
          "@language": "eng"
        }
      ]
    },
    {
      "@id": "_:b9",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Contribution"
      ],
      "http://id.loc.gov/ontologies/bibframe/agent": [
        {
          "@id": "_:b10"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/role": [
        {
          "@id": "http://id.loc.gov/vocabulary/relators/edt"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/genreForms/gf2014026094",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Essays"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/genreForms/gf2016026082",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Festschriften"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/names/n2002092950",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Levering, Matthew, 1971-"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/names/n50045141",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Lubac, Henri de, 1896-1991"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/names/n79043792",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Balthasar, Hans Urs von, 1905-1988"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/names/n87831130",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Fessio, Joseph"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/names/no2006017648",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Healy, Nicholas J., Jr. (Nicholas John)"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/subjects/sh2009007946",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Nouvelle théologie (Catholic theology)"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/subjects/sh85134665",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Theology"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/authorities/subjects/sh85134695",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Theology, Doctrinal--History--20th century"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/vocabulary/contentTypes/txt",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "text"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/vocabulary/languages/eng",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "English"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/vocabulary/relators/edt",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Editor"
        },
        {
          "@value": "http://id.loc.gov/vocabulary/relators/edt"
        }
      ]
    },
    {
      "@id": "http://id.loc.gov/vocabulary/relators/hnr",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "Honoree"
        }
      ]
    },
    {
      "@id": "https://api.sinopia.io/resource/1e64bdb8-e485-4cef-bba8-f66b3d313d27",
      "http://www.w3.org/2000/01/rdf-schema#label": [
        {
          "@value": "https://api.sinopia.io/resource/1e64bdb8-e485-4cef-bba8-f66b3d313d27"
        }
      ]
    },
    {
      "@id": "https://api.sinopia.io/resource/6c59b6f6-6bef-4c1b-a771-dda011f600ed",
      "@type": [
        "http://id.loc.gov/ontologies/bibframe/Work"
      ],
      "http://id.loc.gov/ontologies/bibframe/classification": [
        {
          "@id": "_:b3"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/content": [
        {
          "@id": "http://id.loc.gov/vocabulary/contentTypes/txt"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/contribution": [
        {
          "@id": "_:b0"
        },
        {
          "@id": "_:b6"
        },
        {
          "@id": "_:b9"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/genreForm": [
        {
          "@id": "_:b2"
        },
        {
          "@id": "_:b5"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/hasInstance": [
        {
          "@id": "https://api.sinopia.io/resource/1e64bdb8-e485-4cef-bba8-f66b3d313d27"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/language": [
        {
          "@id": "http://id.loc.gov/vocabulary/languages/eng"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/notation": [
        {
          "@id": "_:b13"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/subject": [
        {
          "@id": "http://id.loc.gov/authorities/names/n50045141"
        },
        {
          "@id": "http://id.loc.gov/authorities/names/n79043792"
        },
        {
          "@id": "http://id.loc.gov/authorities/subjects/sh2009007946"
        },
        {
          "@id": "http://id.loc.gov/authorities/subjects/sh85134665"
        },
        {
          "@id": "http://id.loc.gov/authorities/subjects/sh85134695"
        },
        {
          "@value": "Benedict XVI, Pope, 1927-"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/supplementaryContent": [
        {
          "@id": "_:b11"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/tableOfContents": [
        {
          "@id": "_:b12"
        }
      ],
      "http://id.loc.gov/ontologies/bibframe/title": [
        {
          "@id": "_:b4"
        },
        {
          "@id": "_:b8"
        }
      ],
      "http://sinopia.io/vocabulary/hasResourceTemplate": [
        {
          "@value": "UChicago:RT:bf2:Monograph:Work"
        }
      ]
    }
  ],
  "bfAdminMetadataRefs": [],
  "bfInstanceRefs": [
    "https://api.sinopia.io/resource/1e64bdb8-e485-4cef-bba8-f66b3d313d27"
  ],
  "bfItemRefs": [],
  "bfWorkRefs": [],
  "group": "chicago",
  "types": [
    "http://id.loc.gov/ontologies/bibframe/Work"
  ],
  "user": "tm_dousa",
  "timestamp": "2020-04-21T16:00:05.206Z",
  "templateId": "UChicago:RT:bf2:Monograph:Work",
  "id": "6c59b6f6-6bef-4c1b-a771-dda011f600ed",
  "uri": "https://api.sinopia.io/resource/6c59b6f6-6bef-4c1b-a771-dda011f600ed"
}
            ");


            // Given just the examples, the best program is returned
            var session = new Session();
            session.Constraints.Add(new Example<JToken, JToken>(trainInput, trainOutput));
            Program topRankedProgram = session.Learn();

            if (topRankedProgram == null)
            {
                Console.Error.WriteLine("Error: failed to learn format name program.");
                return;
            }
            // Run the program on the original input
            JToken output = topRankedProgram.Run(input);

            if (output == null)
            {
                Console.Error.WriteLine("Error: failed to execute the program on the input.");
                return;
            }
            Console.WriteLine(output.ToString());

            // Serialize the program, and deserialize it.
            string serializedProgram = topRankedProgram.Serialize();

            Program deserializedProgram = Loader.Instance.Load(serializedProgram);

            if (deserializedProgram == null)
            {
                Console.Error.WriteLine("Error: failed to load deserialized program.");
                return;
            }

            // Run the deserialized program on the original input
            output = deserializedProgram.Run(input);

            if (output == null)
            {
                Console.Error.WriteLine("Error: failed to execute the deserialized program on the input.");
                return;
            }
            Console.WriteLine(output.ToString());
        }
    }
}
