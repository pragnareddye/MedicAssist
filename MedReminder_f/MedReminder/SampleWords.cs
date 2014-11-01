using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections; // for 'IEnumerable'
using System.Collections.Generic; // for 'List'


namespace MedReminder
{
    public class SampleWords : IEnumerable
    {
        public IEnumerable AutoCompletions = new List<string>()
        {
        "Abilify","Acetaminophen","Acyclovir","Adderall","Albuterol","Allegra","Allopurinol","Alprazolam","Ambien","Amiodarone","Amitriptyline","Amlodipine","Amoxicillin","Aricept",
"Aspirin",
"Atenolol",
"Ativan",
"Atorvastatin",
"Augmentin",
"Azithromycin",
"Baclofen",
"Bactrim",
"Bactroban",
"Belviq",
"Benadryl",
"Benicar",
"Biaxin",
"Bisoprolol",
"Boniva",
"Boniva",
"Botox",
"Brilinta",
"Brintellix",
"Bupropion",
"Buspar",
"Buspirone",
"Butrans",
"Bydureon",
"Byetta",
"Bystolic",
"Carbamazepine",
"Carvedilol",
"Celebrex",
"Celexa",
"Cephalexin",
"Cetirizine",
"Cialis",
"Cipro",
"Ciprofloxacin",
"Citalopram",
"Claritin",
"Clindamycin",
"Clonazepam",
"Clonidine",
"Concerta",
"Coreg",
"Coumadin",
"Crestor",
"Cyclobenzaprine",
"Cymbalta",
"Demerol",
"Depakote",
"Depo-Provera",
"Dexamethasone",
"Dextromethorphan",
"Diazepam",
"Diclofenac",
"Diflucan",
"Digoxin",
"Dilantin",
"Dilaudid",
"Diltiazem","Diovan","Diphenhydramine","Ditropan","Dopamine","Doxazosin","Doxycycline","Dulera","DuoNeb","Effexor","Effient","Elavil","Elidel","Eliquis","Enablex","Enalapril","Enbrel","Endocet","Ephedrine","EpiPen","Epogen","Erythromycin","Estrace","Estradiol","Etodolac","Evista","Exalgo","Exelon","Exforge","Famotidine","Farxiga","Fenofibrate","Fentanyl","FerrousSulfate","Fetzima","Fioricet","Fiorinal","FishOil","Flagyl","Flexeril","Flomax","Flonase","Flovent","Fluoxetine","Focalin","FolicAcid","Forteo","Fosamax","Furosemide","Gabapentin","Gammagard","Gamunex","Gardasil","Gazyva","Gelnique","Gemfibrozil","Gemzar","Geodon","Gilenya","Gilotrif","Glassia","Gleevec","Glipizide","Glucophage","Glucotrol","Glucovance","Glyburide","Gralise","Guaifenesin","Halaven","Havrix","Hcg","Heparin","Herceptin","Hetlioz","Hizentra","Hoodia","Horizant","Humalog","Humira","Humulin","HumulinN","Hydrochlorothiazide","Hydrocodone","Hydroxychloroquine","Hydroxyzine","Hylenex","Hytrin","Hyzaar","Ibuprofen","Iclusig","Imbruvica","Imdur","Imitrex","Imodium","Implanon","Incivek","Inderal","Injectafer","Inlyta","Insulin","Integrilin","Intelence","Intermezzo","Intuniv","Invega","Invokana","Isentress","Isosorbide","Jakafi","Jalyn","Janumet","Januvia","Jentadueto","Jetrea","Jevtana","Jublia","Juvederm","Juvisync","Juxtapid","K-dur","Kadcyla","Kadian","Kaletra","Kalydeco","Kapvay","Kazano","Kcentra","Keflex","Kenalog","Keppra","Ketamine","Kineret","Klonopin","Klor-con","KombiglyzeXR","KrillOil","Kuvan","Kyprolis","Kytril","Lamictal","Lansoprazole","Lantus","Lasix","Latuda","Levaquin","Levemir","Levothyroxine","Lexapro","Linzess","Lipitor","Lisinopril","Lithium","Loratadine","Lorazepam","Lortab","Losartan","Lovenox","Lunesta","Lyrica","Macrobid","Meclizine","Melatonin","Meloxicam","Metformin","Methadone","Methocarbamol","Methotrexate","Methylphenidate","Methylprednisolone","Metoclopramide","Metoprolol","Metronidazole","Minocycline","MiraLax","Mirtazapine","Mobic","Morphine","Motrin","Mucinex","Naloxone","Namenda","Naprosyn","Naproxen","Nasacort","Nasonex","Neulasta","Neupogen","Neurontin","Nexium","Niacin","Niaspan","Nifedipine","Nitrofurantoin","Norco","Nortriptyline","Norvasc","NovoLog","Nucynta","Nuvigil","Olysio","Omeprazole","Omnicef","Ondansetron","Onfi","Onglyza","Opana","Oracea","Orapred","Orencia","Orlistat","OrthoEvra","OrthoTri-Cyclen","Oseltamivir","Osphena","Otezla","Oxybutynin","Oxycodone","Oxycontin","Oxytrol","Paracetamol","Paroxetine","Paxil","Penicillin","Percocet","Phenergan","Phentermine","Plavix","PotassiumChloride","Pradaxa","Pravastatin","Prednisone","Premarin","Prevacid","Prilosec","Pristiq","Promethazine","Propranolol","Protonix","Prozac","QNASL","Qnexa","Qsymia","Quaaludes","QuillivantXR","Qutenza","Ramipril","Ranexa","Ranitidine","Rapaflo","Reclast","Reglan","Relafen","Relpax","Remeron","Remicade","Renvela","Requip","Restasis","Restoril","Risperdal","risperidone","Ritalin","Rituxan","Robaxin","Rocephin","Saphris","Savella","Senna","Sensipar","Septra","Seroquel","Sertraline","Simvastatin","Singulair","Skelaxin","Soma","Sonata","Sovaldi","Spiriva","Spironolactone","Strattera","Suboxone","Sudafed","Symbicort","Synthroid","Tamoxifen","Tamsulosin","Tegretol","Temazepam","Tenormin","Terazosin","Testosterone","Tetracycline","Tizanidine","Topamax","Toradol","Toviaz","Tradjenta","Tramadol","Trazodone","Triamcinolone","Triamterene","Tricor","Trileptal","Tylenol","Uceris","Ulesfia","Uloric","Ultane","Ultracet","Ultram","Ultresa","Uroxatral","Valacyclovir","Valium","Valtrex","Vancomycin","Vasotec","Venlafaxine","Ventolin","Verapamil","Vesicare","Viagra","Vicodin","Victoza","Viibryd","Vimovo","Vimpat","Vistaril","Voltaren","VoltarenGel","Vytorin","Vyvanse","Warfarin","Wellbutrin","Wilate","Xalatan","Xalkori","Xanax","XanaxXR","Xarelto","Xeljanz","Xeloda","Xenazine","Xenical","Xeomin","Xgeva","Xiaflex","Xifaxan","Xofigo","Xolair","Xolegel","Xopenex","Xtandi","Xyrem","Xyzal","Yasmin","Yaz","Yervoy","Zanaflex","Zantac","Zestril","Zetia","Zithromax","Zocor","Zofran","ZohydroER","Zoloft","Zolpidem","Zometa","Zonegran","Zostavax","Zosyn","Zovirax","Zubsolv","Zyprexa","Zyrtec","Zytiga","Zyvox"
//"Diltiazem",
//"Diovan",
//"Diphenhydramine","Ditropan","Dopamine","Doxazosin","Doxycycline","Dulera","DuoNeb","Effexor","Effient","Elavil","Elidel","Eliquis","Enablex","Enalapril","Enbrel","Endocet","Ephedrine","EpiPen","Epogen","Erythromycin","Estrace","Estradiol","Etodolac","Evista","Exalgo","Exelon","Exforge","Famotidine","Farxiga","Fenofibrate","Fentanyl"," Ferrous Sulfate"," Fetzima"," Fioricet"," Fiorinal"," Fish Oil"," Flagyl"," Flexeril"," Flomax"," Flonase"," Flovent"," Fluoxetine"," Focalin"," Folic Acid"," Forteo"," Fosamax"," Furosemide"," Gabapentin"," Gammagard"," Gamunex"," Gardasil"," Gazyva"," Gelnique"," Gemfibrozil"," Gemzar"," Geodon"," Gilenya"," Gilotrif"," Glassia"," Gleevec"," Glipizide"," Glucophage"," Glucotrol"," Glucovance"," Glyburide"," Gralise"," Guaifenesin"," Halaven"," Havrix"," Hcg"," Heparin"," Herceptin"," Hetlioz"," Hizentra"," Hoodia"," Horizant"," Humalog"," Humira"," Humulin"," Humulin N"," Hydrochlorothiazide"," Hydrocodone"," Hydroxychloroquine"," Hydroxyzine"," Hylenex"," Hytrin"," Hyzaar"," Ibuprofen"," Iclusig"," Imbruvica"," Imdur"," Imitrex"," Imodium"," Implanon"," Incivek"," Inderal"," Injectafer"," Inlyta"," Insulin"," Integrilin"," Intelence"," Intermezzo"," Intuniv"," Invega"," Invokana"," Isentress"," Isosorbide"," Jakafi"," Jalyn"," Janumet"," Januvia"," Jentadueto"," Jetrea"," Jevtana"," Jublia"," Juvederm"," Juvisync"," Juxtapid"," K-dur"," Kadcyla"," Kadian"," Kaletra"," Kalydeco"," Kapvay"," Kazano"," Kcentra"," Keflex"," Kenalog"," Keppra"," Ketamine"," Kineret"," Klonopin"," Klor-con"," Kombiglyze XR"," Krill Oil"," Kuvan"," Kyprolis"," Kytril"," Lamictal"," Lansoprazole"," Lantus"," Lasix"," Latuda"," Levaquin"," Levemir"," Levothyroxine"," Lexapro"," Linzess"," Lipitor"," Lisinopril"," Lithium"," Loratadine"," Lorazepam"," Lortab"," Losartan"," Lovenox"," Lunesta"," Lyrica"," Macrobid"," Meclizine"," Melatonin"," Meloxicam"," Metformin"," Methadone"," Methocarbamol"," Methotrexate"," Methylphenidate"," Methylprednisolone"," Metoclopramide"," Metoprolol"," Metronidazole"," Minocycline"," MiraLax"," Mirtazapine"," Mobic"," Morphine"," Motrin"," Mucinex"," Naloxone"," Namenda"," Naprosyn"," Naproxen"," Nasacort"," Nasonex"," Neulasta"," Neupogen"," Neurontin"," Nexium"," Niacin"," Niaspan"," Nifedipine"," Nitrofurantoin"," Norco"," Nortriptyline"," Norvasc"," NovoLog"," Nucynta"," Nuvigil"," Olysio"," Omeprazole"," Omnicef"," Ondansetron"," Onfi"," Onglyza"," Opana"," Oracea"," Orapred"," Orencia"," Orlistat"," Ortho Evra"," Ortho Tri-Cyclen"," Oseltamivir"," Osphena"," Otezla"," Oxybutynin"," Oxycodone"," Oxycontin"," Oxytrol"," Paracetamol"," Paroxetine"," Paxil"," Penicillin"," Percocet"," Phenergan"," Phentermine"," Plavix"," Potassium Chloride"," Pradaxa"," Pravastatin"," Prednisone"," Premarin"," Prevacid"," Prilosec"," Pristiq"," Promethazine"," Propranolol"," Protonix"," Prozac"," QNASL"," Qnexa"," Qsymia"," Quaaludes"," Quillivant XR"," Qutenza"," Ramipril"," Ranexa"," Ranitidine"," Rapaflo"," Reclast"," Reglan"," Relafen"," Relpax"," Remeron"," Remicade"," Renvela"," Requip"," Restasis"," Restoril"," Risperdal"," risperidone"," Ritalin"," Rituxan"," Robaxin"," Rocephin"," Saphris"," Savella"," Senna"," Sensipar"," Septra"," Seroquel"," Sertraline"," Simvastatin"," Singulair"," Skelaxin"," Soma"," Sonata"," Sovaldi"," Spiriva"," Spironolactone"," Strattera"," Suboxone"," Sudafed"," Symbicort"," Synthroid"," Tamoxifen"," Tamsulosin"," Tegretol"," Temazepam"," Tenormin"," Terazosin"," Testosterone"," Tetracycline"," Tizanidine"," Topamax"," Toradol"," Toviaz"," Tradjenta"," Tramadol"," Trazodone"," Triamcinolone"," Triamterene"," Tricor"," Trileptal"," Tylenol"," Uceris"," Ulesfia"," Uloric"," Ultane"," Ultracet"," Ultram"," Ultresa"," Uroxatral"," Valacyclovir"," Valium"," Valtrex"," Vancomycin"," Vasotec"," Venlafaxine"," Ventolin"," Verapamil"," Vesicare"," Viagra"," Vicodin"," Victoza"," Viibryd"," Vimovo"," Vimpat"," Vistaril"," Voltaren"," Voltaren Gel"," Vytorin"," Vyvanse"," Warfarin"," Wellbutrin"," Wilate"," Xalatan"," Xalkori"," Xanax"," Xanax XR"," Xarelto"," Xeljanz"," Xeloda"," Xenazine"," Xenical"," Xeomin"," Xgeva"," Xiaflex"," Xifaxan"," Xofigo"," Xolair"," Xolegel"," Xopenex"," Xtandi"," Xyrem"," Xyzal"," Yasmin"," Yaz"," Yervoy"," Zanaflex"," Zantac"," Zestril"," Zetia"," Zithromax"," Zocor"," Zofran"," Zohydro ER"," Zoloft"," Zolpidem"," Zometa"," Zonegran"," Zostavax"," Zosyn"," Zovirax"," Zubsolv"," Zyprexa"," Zyrtec"," Zytiga"," Zyvox" 
        };

        public IEnumerator GetEnumerator()
        {
            return AutoCompletions.GetEnumerator();
        }
    }
}
