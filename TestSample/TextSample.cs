﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountWordFrequencyTest {
    public static class TextSample {
        public static string ShortText = "Ala ma kota kot ma ale kot ala ma nie coś";
        // 7 słów
        // ala 2
        // ma 3 
        // kota 1
        // kot 2
        // ale 1
        // nie 1
        // coś 1

        static string m_longText = "";
        public static string LongText {
            get {
                if (m_longText == "") {
                    for (int i = 0; i < 10; i++) {
                        m_longText += m_baseText;
                    }
                }
                return m_longText;
            }
        }
        /// <summary>
        /// Tekst bazowy do klejenia
        /// </summary>
        public static string m_baseText =
" 1. " +
" " +
"How by a certain machine many may stay some time under water. And " +
"how and wherefore I do not describe my method of remaining under " +
"water and how long I can remain without eating. And I do not publish " +
"nor divulge these, by reason of the evil nature of men, who would " +
"use them for assassinations at the bottom of the sea by destroying " +
"ships, and sinking them, together with the men in them. Nevertheless " +
"I will impart others, which are not dangerous because the mouth of " +
"the tube through which you breathe is above the water, supported on " +
"air sacks or cork. " +
" " +
"[Footnote: The leaf on which this passage is written, is headed with " +
"the words _Casi_ 39, and most of these cases begin with the word " +
"'_Come_', like the two here given, which are the 26th and 27th. 7. " +
"_Sughero_. In the Codex Antlanticus 377a; 1170a there is a sketch, " +
"drawn with the pen, representing a man with a tube in his mouth, and " +
"at the farther end of the tube a disk. By the tube the word " +
"'_Channa_' is written, and by the disk the word '_sughero_'.] " +
" " +
"The preparation of the MSS. for publication. " +
" " +
"2. " +
" " +
"When you put together the science of the motions of water, remember " +
"to include under each proposition its application and use, in order " +
"that this science may not be useless.-- " +
" " +
"[Footnote: A comparatively small portion of Leonardo's notes on " +
"water-power was published at Bologna in 1828, under the title: \"_Del " +
"moto e misura dell'Acqua, di L. da Vinci_\".] " +
" " +
"Admonition to readers. " +
" " +
"3. " +
" " +
"Let no man who is not a Mathematician read the elements of my work. " +
" " +
"The disorder in the MSS. " +
" " +
"4. " +
" " +
"Begun at Florence, in the house of Piero di Braccio Martelli, on the " +
"22nd day of March 1508. And this is to be a collection without " +
"order, taken from many papers which I have copied here, hoping to " +
"arrange them later each in its place, according to the subjects of " +
"which they may treat. But I believe that before I am at the end of " +
"this [task] I shall have to repeat the same things several times; " +
"for which, O reader! do not blame me, for the subjects are many and " +
"memory cannot retain them [all] and say: 'I will not write this " +
"because I wrote it before.' And if I wished to avoid falling into " +
"this fault, it would be necessary in every case when I wanted to " +
"copy [a passage] that, not to repeat myself, I should read over all " +
"that had gone before; and all the more since the intervals are long " +
"between one time of writing and the next. " +
" " +
"[Footnote: 1. In the history of Florence in the early part of the " +
"XVIth century _Piero di Braccio Martelli_ is frequently mentioned as " +
"_Commissario della Signoria_. He was famous for his learning and at " +
"his death left four books on Mathematics ready for the press; comp. " +
"LITTA, _Famiglie celebri Italiane_, _Famiglia Martelli di " +
"Firenze_.--In the Official Catalogue of MSS. in the Brit. Mus., New " +
"Series Vol. I., where this passage is printed, _Barto_ has been " +
"wrongly given for Braccio. " +
" " +
"2. _addi 22 di marzo 1508_. The Christian era was computed in " +
"Florence at that time from the Incarnation (Lady day, March 25th). " +
"Hence this should be 1509 by our reckoning. " +
" " +
"3. _racolto tratto di molte carte le quali io ho qui copiate_. We " +
"must suppose that Leonardo means that he has copied out his own MSS. " +
"and not those of others. The first thirteen leaves of the MS. in the " +
"Brit. Mus. are a fair copy of some notes on physics.] " +
" " +
"Suggestions for the arrangement of MSS treating of particular " +
"subjects.(5-8). " +
" " +
"5. " +
" " +
"Of digging a canal. Put this in the Book of useful inventions and in " +
"proving them bring forward the propositions already proved. And this " +
"is the proper order; since if you wished to show the usefulness of " +
"any plan you would be obliged again to devise new machines to prove " +
"its utility and thus would confuse the order of the forty Books and " +
"also the order of the diagrams; that is to say you would have to mix " +
"up practice with theory, which would produce a confused and " +
"incoherent work. " +
" " +
"6. " +
" " +
"I am not to blame for putting forward, in the course of my work on " +
"science, any general rule derived from a previous conclusion. " +
" " +
"7. " +
" " +
"The Book of the science of Mechanics must precede the Book of useful " +
"inventions.--Have your books on anatomy bound! [Footnote: 4. The " +
"numerous notes on anatomy written on loose leaves and now in the " +
"Royal collection at Windsor can best be classified in four Books, " +
"corresponding to the different character and size of the paper. When " +
"Leonardo speaks of '_li tua libri di notomia_', he probably means " +
"the MSS. which still exist; if this hypothesis is correct the " +
"present condition of these leaves might seem to prove that he only " +
"carried out his purpose with one of the Books on anatomy. A borrowed " +
"book on Anatomy is mentioned in F.O.] " +
" " +
"8. " +
" " +
"The order of your book must proceed on this plan: first simple " +
"beams, then (those) supported from below, then suspended in part, " +
"then wholly [suspended]. Then beams as supporting other weights " +
"[Footnote: 4. Leonardo's notes on Mechanics are extraordinarily " +
"numerous; but, for the reasons assigned in my introduction, they " +
"have not been included in the present work.]. " +
" " +
"General introductions to the book on Painting (9-13). " +
" " +
"9. " +
" " +
"INTRODUCTION. " +
" " +
"Seeing that I can find no subject specially useful or " +
"pleasing--since the men who have come before me have taken for their " +
"own every useful or necessary theme--I must do like one who, being " +
"poor, comes last to the fair, and can find no other way of providing " +
"himself than by taking all the things already seen by other buyers, " +
"and not taken but refused by reason of their lesser value. I, then, " +
"will load my humble pack with this despised and rejected " +
"merchandise, the refuse of so many buyers; and will go about to " +
"distribute it, not indeed in great cities, but in the poorer towns, " +
"taking such a price as the wares I offer may be worth. [Footnote: It " +
"need hardly be pointed out that there is in this 'Proemio' a covert " +
"irony. In the second and third prefaces, Leonardo characterises his " +
"rivals and opponents more closely. His protest is directed against " +
"Neo-latinism as professed by most of the humanists of his time; its " +
"futility is now no longer questioned.] " +
" " +
"10. " +
" " +
"INTRODUCTION. " +
" " +
"I know that many will call this useless work [Footnote: 3. questa " +
"essere opera inutile. By opera we must here understand libro di " +
"pittura and particularly the treatise on Perspective.]; and they " +
"will be those of whom Demetrius [Footnote: 4. Demetrio. \"With regard " +
"to the passage attributed to Demetrius\", Dr. H. Mï¿½LLER STRï¿½BING " +
"writes, \"I know not what to make of it. It is certainly not " +
"Demetrius Phalereus that is meant and it can hardly be Demetrius " +
"Poliorcetes. Who then can it be--for the name is a very common one? " +
"It may be a clerical error for Demades and the maxim is quite in the " +
"spirit of his writings I have not however been able to find any " +
"corresponding passage either in the 'Fragments' (C. MULLER, _Orat. " +
"Att._, II. 441) nor in the Supplements collected by DIETZ (_Rhein. " +
"Mus._, vol. 29, p. 108).\" " +
" " +
"The same passage occurs as a simple Memorandum in the MS. Tr. 57, " +
"apparently as a note for this '_Proemio_' thus affording some data " +
"as to the time where these introductions were written.] declared " +
"that he took no more account of the wind that came out their mouth " +
"in words, than of that they expelled from their lower parts: men who " +
"desire nothing but material riches and are absolutely devoid of that " +
"of wisdom, which is the food and the only true riches of the mind. " +
"For so much more worthy as the soul is than the body, so much more " +
"noble are the possessions of the soul than those of the body. And " +
"often, when I see one of these men take this work in his hand, I " +
"wonder that he does not put it to his nose, like a monkey, or ask me " +
"if it is something good to eat. " +
" " +
"[Footnote: In the original, the Proemio dï¿½ prospettiva cioï¿½ " +
"dell'uffitio dell'occhio (see No. 21) stands between this and the " +
"preceding one, No. 9.] " +
" " +
"INTRODUCTION. " +
" " +
"I am fully concious that, not being a literary man, certain " +
"presumptuous persons will think that they may reasonably blame me; " +
"alleging that I am not a man of letters. Foolish folks! do they not " +
"know that I might retort as Marius did to the Roman Patricians " +
"[Footnote 21: _Come Mario disse ai patriti Romani_. \"I am unable to " +
"find the words here attributed by Leonardo to Marius, either in " +
"Plutarch's Life of Marius or in the Apophthegmata (_Moralia_, " +
"p.202). Nor do they occur in the writings of Valerius Maximus (who " +
"frequently mentions Marius) nor in Velleius Paterculus (II, 11 to " +
"43), Dio Cassius, Aulus Gellius, or Macrobius. Professor E. " +
"MENDELSON of Dorpat, the editor of Herodian, assures me that no such " +
"passage is the found in that author\" (communication from Dr. MULLER " +
"STRUBING). Leonardo evidently meant to allude to some well known " +
"incident in Roman history and the mention of Marius is the result " +
"probably of some confusion. We may perhaps read, for Marius, " +
"Menenius Agrippa, though in that case it is true we must alter " +
"Patriti to Plebei. The change is a serious one. but it would render " +
"the passage perfectly clear.] by saying: That they, who deck " +
"themselves out in the labours of others will not allow me my own. " +
"They will say that I, having no literary skill, cannot properly " +
"express that which I desire to treat of [Footnote 26: _le mie cose " +
".... che d'altra parola_. This can hardly be reconciled with Mons. " +
"RAVAISSON'S estimate of L. da Vinci's learning. \"_Leonard de Vinci " +
"etait un admirateur et un disciple des anciens, aussi bien dans " +
"l'art que dans la science et il tenait a passer pour tel meme aux " +
"yeux de la posterite._\" _Gaz. des Beaux arts. Oct. 1877.]; but they " +
"do not know that my subjects are to be dealt with by experience " +
"rather than by words [Footnote 28: See Footnote 26]; and " +
"[experience] has been the mistress of those who wrote well. And so, " +
"as mistress, I will cite her in all cases. " +
" " +
"11. " +
" " +
"Though I may not, like them, be able to quote other authors, I shall " +
"rely on that which is much greater and more worthy:--on experience, " +
"the mistress of their Masters. They go about puffed up and pompous, " +
"dressed and decorated with [the fruits], not of their own labours, " +
"but of those of others. And they will not allow me my own. They will " +
"scorn me as an inventor; but how much more might they--who are not " +
"inventors but vaunters and declaimers of the works of others--be " +
"blamed. " +
" " +
"INTRODUCTION. " +
" " +
"And those men who are inventors and interpreters between Nature and " +
"Man, as compared with boasters and declaimers of the works of " +
"others, must be regarded and not otherwise esteemed than as the " +
"object in front of a mirror, when compared with its image seen in " +
"the mirror. For the first is something in itself, and the other " +
"nothingness.--Folks little indebted to Nature, since it is only by " +
"chance that they wear the human form and without it I might class " +
"them with the herds of beasts. " +
" " +
"12. " +
" " +
"Many will think they may reasonably blame me by alleging that my " +
"proofs are opposed to the authority of certain men held in the " +
"highest reverence by their inexperienced judgments; not considering " +
"that my works are the issue of pure and simple experience, who is " +
"the one true mistress. These rules are sufficient to enable you to " +
"know the true from the false--and this aids men to look only for " +
"things that are possible and with due moderation--and not to wrap " +
"yourself in ignorance, a thing which can have no good result, so " +
"that in despair you would give yourself up to melancholy. " +
" " +
"13. " +
" " +
"Among all the studies of natural causes and reasons Light chiefly " +
"delights the beholder; and among the great features of Mathematics " +
"the certainty of its demonstrations is what preeminently (tends to) " +
"elevate the mind of the investigator. Perspective, therefore, must " +
"be preferred to all the discourses and systems of human learning. In " +
"this branch [of science] the beam of light is explained on those " +
"methods of demonstration which form the glory not so much of " +
"Mathematics as of Physics and are graced with the flowers of both " +
"[Footnote: 5. Such of Leonardo's notes on Optics or on Perspective " +
"as bear exclusively on Mathematics or Physics could not be included " +
"in the arrangement of the _libro di pittura_ which is here presented " +
"to the reader. They are however but few.]. But its axioms being laid " +
"down at great length, I shall abridge them to a conclusive brevity, " +
"arranging them on the method both of their natural order and of " +
"mathematical demonstration; sometimes by deduction of the effects " +
"from the causes, and sometimes arguing the causes from the effects; " +
"adding also to my own conclusions some which, though not included in " +
"them, may nevertheless be inferred from them. Thus, if the Lord--who " +
"is the light of all things--vouchsafe to enlighten me, I will treat " +
"of Light; wherefore I will divide the present work into 3 Parts " +
"[Footnote: 10. In the middle ages--for instance, by ROGER BACON, by " +
"VITELLONE, with whose works Leonardo was certainly familiar, and by " +
"all the writers of the Renaissance Perspective and Optics were not " +
"regarded as distinct sciences. Perspective, indeed, is in its widest " +
"application the science of seeing. Although to Leonardo the two " +
"sciences were clearly separate, it is not so as to their names; thus " +
"we find axioms in Optics under the heading Perspective. According to " +
"this arrangement of the materials for the theoretical portion of the " +
"_libro di pittura_ propositions in Perspective and in Optics stand " +
"side by side or occur alternately. Although this particular chapter " +
"deals only with Optics, it is not improbable that the words _partirï¿½ " +
"la presente opera in 3 parti_ may refer to the same division into " +
"three sections which is spoken of in chapters 14 to 17.]. " +
" " +
"The plan of the book on Painting (14--17). " +
" " +
"14. " +
" " +
"ON THE THREE BRANCHES OF PERSPECTIVE. " +
" " +
"There are three branches of perspective; the first deals with the " +
"reasons of the (apparent) diminution of objects as they recede from " +
"the eye, and is known as Diminishing Perspective.--The second " +
"contains the way in which colours vary as they recede from the eye. " +
"The third and last is concerned with the explanation of how the " +
"objects [in a picture] ought to be less finished in proportion as " +
"they are remote (and the names are as follows): " +
" " +
"Linear Perspective. The Perspective of Colour. The Perspective of " +
"Disappearance. " +
" " +
"[Footnote: 13. From the character of the handwriting I infer that " +
"this passage was written before the year 1490.]. " +
" " +
"15. " +
" " +
"ON PAINTING AND PERSPECTIVE. " +
" " +
"The divisions of Perspective are 3, as used in drawing; of these, " +
"the first includes the diminution in size of opaque objects; the " +
"second treats of the diminution and loss of outline in such opaque " +
"objects; the third, of the diminution and loss of colour at long " +
"distances. " +
" " +
"[Footnote: The division is here the same as in the previous chapter " +
"No. 14, and this is worthy of note when we connect it with the fact " +
"that a space of about 20 years must have intervened between the " +
"writing of the two passages.] " +
" " +
"16. " +
" " +
"THE DISCOURSE ON PAINTING. " +
" " +
"Perspective, as bearing on drawing, is divided into three principal " +
"sections; of which the first treats of the diminution in the size of " +
"bodies at different distances. The second part is that which treats " +
"of the diminution in colour in these objects. The third [deals with] " +
"the diminished distinctness of the forms and outlines displayed by " +
"the objects at various distances. " +
" " +
"17. " +
" " +
"ON THE SECTIONS OF [THE BOOK ON] PAINTING. " +
" " +
"The first thing in painting is that the objects it represents should " +
"appear in relief, and that the grounds surrounding them at different " +
"distances shall appear within the vertical plane of the foreground " +
"of the picture by means of the 3 branches of Perspective, which are: " +
"the diminution in the distinctness of the forms of the objects, the " +
"diminution in their magnitude; and the diminution in their colour. " +
"And of these 3 classes of Perspective the first results from [the " +
"structure of] the eye, while the other two are caused by the " +
"atmosphere which intervenes between the eye and the objects seen by " +
"it. The second essential in painting is appropriate action and a due " +
"variety in the figures, so that the men may not all look like " +
"brothers, &c. " +
" " +
"[Footnote: This and the two foregoing chapters must have been " +
"written in 1513 to 1516. They undoubtedly indicate the scheme which " +
"Leonardo wished to carry out in arranging his researches on " +
"Perspective as applied to Painting. This is important because it is " +
"an evidence against the supposition of H. LUDWIG and others, that " +
"Leonardo had collected his principles of Perspective in one book so " +
"early as before 1500; a Book which, according to the hypothesis, " +
"must have been lost at a very early period, or destroyed possibly, " +
"by the French (!) in 1500 (see H. LUDWIG. L. da Vinci: _Das Buch van " +
"der Malerei_. Vienna 1882 III, 7 and 8).] " +
" " +
"The use of the book on Painting. " +
" " +
"18. " +
" " +
"These rules are of use only in correcting the figures; since every " +
"man makes some mistakes in his first compositions and he who knows " +
"them not, cannot amend them. But you, knowing your errors, will " +
"correct your works and where you find mistakes amend them, and " +
"remember never to fall into them again. But if you try to apply " +
"these rules in composition you will never make an end, and will " +
"produce confusion in your works. " +
" " +
"These rules will enable you to have a free and sound judgment; since " +
"good judgment is born of clear understanding, and a clear " +
"understanding comes of reasons derived from sound rules, and sound " +
"rules are the issue of sound experience--the common mother of all " +
"the sciences and arts. Hence, bearing in mind the precepts of my " +
"rules, you will be able, merely by your amended judgment, to " +
"criticise and recognise every thing that is out of proportion in a " +
"work, whether in the perspective or in the figures or any thing " +
"else. " +
" " +
"Necessity of theoretical knowledge (19. 20). " +
" " +
"19. " +
" " +
"OF THE MISTAKES MADE BY THOSE WHO PRACTISE WITHOUT KNOWLEDGE. " +
" " +
"Those who are in love with practice without knowledge are like the " +
"sailor who gets into a ship without rudder or compass and who never " +
"can be certain whether he is going. Practice must always be founded " +
"on sound theory, and to this Perspective is the guide and the " +
"gateway; and without this nothing can be done well in the matter of " +
"drawing. " +
" " +
"20. " +
" " +
"The painter who draws merely by practice and by eye, without any " +
"reason, is like a mirror which copies every thing placed in front of " +
"it without being conscious of their existence. " +
" " +
"The function of the eye (21-23). " +
" " +
"21. " +
" " +
"INTRODUCTION TO PERSPECTIVE:--THAT IS OF THE FUNCTION OF THE EYE. " +
" " +
"Behold here O reader! a thing concerning which we cannot trust our " +
"forefathers, the ancients, who tried to define what the Soul and " +
"Life are--which are beyond proof, whereas those things, which can at " +
"any time be clearly known and proved by experience, remained for " +
"many ages unknown or falsely understood. The eye, whose function we " +
"so certainly know by experience, has, down to my own time, been " +
"defined by an infinite number of authors as one thing; but I find, " +
"by experience, that it is quite another. [Footnote 13: Compare the " +
"note to No. 70.] " +
" " +
"[Footnote: In section 13 we already find it indicated that the study " +
"of Perspective and of Optics is to be based on that of the functions " +
"of the eye. Leonardo also refers to the science of the eye, in his " +
"astronomical researches, for instance in MS. F 25b '_Ordine del " +
"provare la terra essere una stella: Imprima difinisce l'occhio'_, " +
"&c. Compare also MS. E 15b and F 60b. The principles of astronomical " +
"perspective.] " +
" " +
"22. " +
" " +
"Here [in the eye] forms, here colours, here the character of every " +
"part of the universe are concentrated to a point; and that point is " +
"so marvellous a thing ... Oh! marvellous, O stupendous Necessity--by " +
"thy laws thou dost compel every effect to be the direct result of " +
"its cause, by the shortest path. These [indeed] are miracles;... " +
" " +
"In so small a space it can be reproduced and rearranged in its whole " +
"expanse. Describe in your anatomy what proportion there is between " +
"the diameters of all the images in the eye and the distance from " +
"them of the crystalline lens. " +
" " +
"23. " +
" " +
"OF THE 10 ATTRIBUTES OF THE EYE, ALL CONCERNED IN PAINTING. " +
" " +
"Painting is concerned with all the 10 attributes of sight; which " +
"are:--Darkness, Light, Solidity and Colour, Form and Position, " +
"Distance and Propinquity, Motion and Rest. This little work of mine " +
"will be a tissue [of the studies] of these attributes, reminding the " +
"painter of the rules and methods by which he should use his art to " +
"imitate all the works of Nature which adorn the world. " +
" " +
"24. " +
" " +
"ON PAINTING. " +
" " +
"Variability of the eye. " +
" " +
"1st. The pupil of the eye contracts, in proportion to the increase " +
"of light which is reflected in it. 2nd. The pupil of the eye expands " +
"in proportion to the diminution in the day light, or any other " +
"light, that is reflected in it. 3rd. [Footnote: 8. The subject of " +
"this third proposition we find fully discussed in MS. G. 44a.]. The " +
"eye perceives and recognises the objects of its vision with greater " +
"intensity in proportion as the pupil is more widely dilated; and " +
"this can be proved by the case of nocturnal animals, such as cats, " +
"and certain birds--as the owl and others--in which the pupil varies " +
"in a high degree from large to small, &c., when in the dark or in " +
"the light. 4th. The eye [out of doors] in an illuminated atmosphere " +
"sees darkness behind the windows of houses which [nevertheless] are " +
"light. 5th. All colours when placed in the shade appear of an equal " +
"degree of darkness, among themselves. 6th. But all colours when " +
"placed in a full light, never vary from their true and essential " +
"hue. " +
" " +
"25. " +
" " +
"OF THE EYE. " +
" " +
"Focus of sight. " +
" " +
"If the eye is required to look at an object placed too near to it, " +
"it cannot judge of it well--as happens to a man who tries to see the " +
"tip of his nose. Hence, as a general rule, Nature teaches us that an " +
"object can never be seen perfectly unless the space between it and " +
"the eye is equal, at least, to the length of the face. " +
" " +
"Differences of perception by one eye and by both eyes (26-29). " +
" " +
"26. " +
" " +
"OF THE EYE. " +
" " +
"When both eyes direct the pyramid of sight to an object, that object " +
"becomes clearly seen and comprehended by the eyes. " +
" " +
"27. " +
" " +
"Objects seen by one and the same eye appear sometimes large, and " +
"sometimes small. " +
" " +
"28. " +
" " +
"The motion of a spectator who sees an object at rest often makes it " +
"seem as though the object at rest had acquired the motion of the " +
"moving body, while the moving person appears to be at rest. " +
" " +
"ON PAINTING. " +
" " +
"Objects in relief, when seen from a short distance with one eye, " +
"look like a perfect picture. If you look with the eye _a_, _b_ at " +
"the spot _c_, this point _c_ will appear to be at _d_, _f_, and if " +
"you look at it with the eye _g_, _h_ will appear to be at _m_. A " +
"picture can never contain in itself both aspects. " +
" " +
"29. " +
" " +
"Let the object in relief _t_ be seen by both eyes; if you will look " +
"at the object with the right eye _m_, keeping the left eye _n_ shut, " +
"the object will appear, or fill up the space, at _a_; and if you " +
"shut the right eye and open the left, the object (will occupy the) " +
"space _b_; and if you open both eyes, the object will no longer " +
"appear at _a_ or _b_, but at _e_, _r_, _f_. Why will not a picture " +
"seen by both eyes produce the effect of relief, as [real] relief " +
"does when seen by both eyes; and why should a picture seen with one " +
"eye give the same effect of relief as real relief would under the " +
"same conditions of light and shade? " +
" " +
"[Footnote: In the sketch, _m_ is the left eye and _n_ the right, " +
"while the text reverses this lettering. We must therefore suppose " +
"that the face in which the eyes _m_ and _n_ are placed is opposite " +
"to the spectator.] " +
" " +
"30. " +
" " +
"The comparative size of the image depends on the amount of light " +
"(30-39). " +
" " +
"The eye will hold and retain in itself the image of a luminous body " +
"better than that of a shaded object. The reason is that the eye is " +
"in itself perfectly dark and since two things that are alike cannot " +
"be distinguished, therefore the night, and other dark objects cannot " +
"be seen or recognised by the eye. Light is totally contrary and " +
"gives more distinctness, and counteracts and differs from the usual " +
"darkness of the eye, hence it leaves the impression of its image. " +
" " +
"31. " +
" " +
"Every object we see will appear larger at midnight than at midday, " +
"and larger in the morning than at midday. " +
" " +
"This happens because the pupil of the eye is much smaller at midday " +
"than at any other time. " +
" " +
"32. " +
" " +
"The pupil which is largest will see objects the largest. This is " +
"evident when we look at luminous bodies, and particularly at those " +
"in the sky. When the eye comes out of darkness and suddenly looks up " +
"at these bodies, they at first appear larger and then diminish; and " +
"if you were to look at those bodies through a small opening, you " +
"would see them smaller still, because a smaller part of the pupil " +
"would exercise its function. " +
" " +
"[Footnote: 9. _buso_ in the Lomb. dialect is the same as _buco_.] " +
" " +
"33. " +
" " +
"When the eye, coming out of darkness suddenly sees a luminous body, " +
"it will appear much larger at first sight than after long looking at " +
"it. The illuminated object will look larger and more brilliant, when " +
"seen with two eyes than with only one. A luminous object will appear " +
"smaller in size, when the eye sees it through a smaller opening. A " +
"luminous body of an oval form will appear rounder in proportion as " +
"it is farther from the eye. " +
" " +
"34. " +
" " +
"Why when the eye has just seen the light, does the half light look " +
"dark to it, and in the same way if it turns from the darkness the " +
"half light look very bright? " +
" " +
"35. " +
" " +
"ON PAINTING. " +
" " +
"If the eye, when [out of doors] in the luminous atmosphere, sees a " +
"place in shadow, this will look very much darker than it really is. " +
"This happens only because the eye when out in the air contracts the " +
"pupil in proportion as the atmosphere reflected in it is more " +
"luminous. And the more the pupil contracts, the less luminous do the " +
"objects appear that it sees. But as soon as the eye enters into a " +
"shady place the darkness of the shadow suddenly seems to diminish. " +
"This occurs because the greater the darkness into which the pupil " +
"goes the more its size increases, and this increase makes the " +
"darkness seem less. " +
" " +
"[Footnote 14: _La luce entrerï¿½_. _Luce_ occurs here in the sense of " +
"pupil of the eye as in no 51: C. A. 84b; 245a; I--5; and in many " +
"other places.] " +
" " +
"36. " +
" " +
"ON PERSPECTIVE. " +
" " +
"The eye which turns from a white object in the light of the sun and " +
"goes into a less fully lighted place will see everything as dark. " +
"And this happens either because the pupils of the eyes which have " +
"rested on this brilliantly lighted white object have contracted so " +
"much that, given at first a certain extent of surface, they will " +
"have lost more than 3/4 of their size; and, lacking in size, they " +
"are also deficient in [seeing] power. Though you might say to me: A " +
"little bird (then) coming down would see comparatively little, and " +
"from the smallness of his pupils the white might seem black! To this " +
"I should reply that here we must have regard to the proportion of " +
"the mass of that portion of the brain which is given up to the sense " +
"of sight and to nothing else. Or--to return--this pupil in Man " +
"dilates and contracts according to the brightness or darkness of " +
"(surrounding) objects; and since it takes some time to dilate and " +
"contract, it cannot see immediately on going out of the light and " +
"into the shade, nor, in the same way, out of the shade into the " +
"light, and this very thing has already deceived me in painting an " +
"eye, and from that I learnt it. " +
" " +
"37. " +
" " +
"Experiment [showing] the dilatation and contraction of the pupil, " +
"from the motion of the sun and other luminaries. In proportion as " +
"the sky is darker the stars appear of larger size, and if you were " +
"to light up the medium these stars would look smaller; and this " +
"difference arises solely from the pupil which dilates and contracts " +
"with the amount of light in the medium which is interposed between " +
"the eye and the luminous body. Let the experiment be made, by " +
"placing a candle above your head at the same time that you look at a " +
"star; then gradually lower the candle till it is on a level with the " +
"ray that comes from the star to the eye, and then you will see the " +
"star diminish so much that you will almost lose sight of it. " +
" " +
"[Footnote: No reference is made in the text to the letters on the " +
"accompanying diagram.] " +
" " +
"38. " +
" " +
"The pupil of the eye, in the open air, changes in size with every " +
"degree of motion from the sun; and at every degree of its changes " +
"one and the same object seen by it will appear of a different size; " +
"although most frequently the relative scale of surrounding objects " +
"does not allow us to detect these variations in any single object we " +
"may look at. " +
" " +
"39. " +
" " +
"The eye--which sees all objects reversed--retains the images for " +
"some time. This conclusion is proved by the results; because, the " +
"eye having gazed at light retains some impression of it. After " +
"looking (at it) there remain in the eye images of intense " +
"brightness, that make any less brilliant spot seem dark until the " +
"eye has lost the last trace of the impression of the stronger light. " +
" " +
"_II. " +
" " +
"Linear Perspective. " +
" " +
"We see clearly from the concluding sentence of section 49, where the " +
"author directly addresses the painter, that he must certainly have " +
"intended to include the elements of mathematics in his Book on the " +
"art of Painting. They are therefore here placed at the beginning. In " +
"section 50 the theory of the \"Pyramid of Sight\" is distinctly and " +
"expressly put forward as the fundamental principle of linear " +
"perspective, and sections 52 to 57 treat of it fully. This theory of " +
"sight can scarcely be traced to any author of antiquity. Such " +
"passages as occur in Euclid for instance, may, it is true, have " +
"proved suggestive to the painters of the Renaissance, but it would " +
"be rash to say any thing decisive on this point. " +
" " +
"Leon Battista Alberti treats of the \"Pyramid of Sight\" at some " +
"length in his first Book of Painting; but his explanation differs " +
"widely from Leonardo's in the details. Leonardo, like Alberti, may " +
"have borrowed the broad lines of his theory from some views commonly " +
"accepted among painters at the time; but he certainly worked out its " +
"application in a perfectly original manner. " +
" " +
"The axioms as to the perception of the pyramid of rays are followed " +
"by explanations of its origin, and proofs of its universal " +
"application (58--69). The author recurs to the subject with endless " +
"variations; it is evidently of fundamental importance in his " +
"artistic theory and practice. It is unnecessary to discuss how far " +
"this theory has any scientific value at the present day; so much as " +
"this, at any rate, seems certain: that from the artist's point of " +
"view it may still claim to be of immense practical utility. " +
" " +
"According to Leonardo, on one hand, the laws of perspective are an " +
"inalienable condition of the existence of objects in space; on the " +
"other hand, by a natural law, the eye, whatever it sees and wherever " +
"it turns, is subjected to the perception of the pyramid of rays in " +
"the form of a minute target. Thus it sees objects in perspective " +
"independently of the will of the spectator, since the eye receives " +
"the images by means of the pyramid of rays \"just as a magnet " +
"attracts iron\". " +
" " +
"In connection with this we have the function of the eye explained by " +
"the Camera obscura, and this is all the more interesting and " +
"important because no writer previous to Leonardo had treated of this " +
"subject_ (70--73). _Subsequent passages, of no less special interest, " +
"betray his knowledge of refraction and of the inversion of the image " +
"in the camera and in the eye_ (74--82). " +
" " +
"_From the principle of the transmission of the image to the eye and " +
"to the camera obscura he deduces the means of producing an " +
"artificial construction of the pyramid of rays or--which is the same " +
"thing--of the image. The fundamental axioms as to the angle of sight " +
"and the vanishing point are thus presented in a manner which is as " +
"complete as it is simple and intelligible_ (86--89). " +
" " +
"_Leonardo distinguishes between simple and complex perspective_ (90, " +
"91). _The last sections treat of the apparent size of objects at " +
"various distances and of the way to estimate it_ (92--109). " +
" " +
"General remarks on perspective (40-41). " +
" " +
"40. " +
" " +
"ON PAINTING. " +
" " +
"Perspective is the best guide to the art of Painting. " +
" " +
"[Footnote: 40. Compare 53, 2.] " +
" " +
"41. " +
" " +
"The art of perspective is of such a nature as to make what is flat " +
"appear in relief and what is in relief flat. " +
" " +
"The elements of perspective--Of the Point (42-46). " +
" " +
"42. " +
" " +
"All the problems of perspective are made clear by the five terms of " +
"mathematicians, which are:--the point, the line, the angle, the " +
"superficies and the solid. The point is unique of its kind. And the " +
"point has neither height, breadth, length, nor depth, whence it is " +
"to be regarded as indivisible and as having no dimensions in space. " +
"The line is of three kinds, straight, curved and sinuous and it has " +
"neither breadth, height, nor depth. Hence it is indivisible, " +
"excepting in its length, and its ends are two points. The angle is " +
"the junction of two lines in a point. " +
" " +
"43. " +
" " +
"A point is not part of a line. " +
" " +
"44. " +
" " +
"OF THE NATURAL POINT. " +
" " +
"The smallest natural point is larger than all mathematical points, " +
"and this is proved because the natural point has continuity, and any " +
"thing that is continuous is infinitely divisible; but the " +
"mathematical point is indivisible because it has no size. " +
" " +
"[Footnote: This definition was inserted by Leonardo on a MS. copy on " +
"parchment of the well-known _\"Trattato d'Architettura civile e " +
"militare\"_ &c. by FRANCESCO DI GIORGIO; opposite a passage where the " +
"author says: _'In prima he da sapere che punto ï¿½ quella parie della " +
"quale he nulla--Linia he luncheza senza ï¿½pieza; &c.] " +
" " +
"45. " +
" " +
"1, The superficies is a limitation of the body. 2, and the " +
"limitation of a body is no part of that body. 4, and the limitation " +
"of one body is that which begins another. 3, that which is not part " +
"of any body is nothing. Nothing is that which fills no space. " +
" " +
"If one single point placed in a circle may be the starting point of " +
"an infinite number of lines, and the termination of an infinite " +
"number of lines, there must be an infinite number of points " +
"separable from this point, and these when reunited become one again; " +
"whence it follows that the part may be equal to the whole. " +
" " +
"46. " +
" " +
"The point, being indivisible, occupies no space. That which occupies " +
"no space is nothing. The limiting surface of one thing is the " +
"beginning of another. 2. That which is no part of any body is called " +
"nothing. 1. That which has no limitations, has no form. The " +
"limitations of two conterminous bodies are interchangeably the " +
"surface of each. All the surfaces of a body are not parts of that " +
"body. " +
" " +
"Of the line (47-48). " +
" " +
"47. " +
" " +
"DEFINITION OF THE NATURE OF THE LINE. " +
" " +
"The line has in itself neither matter nor substance and may rather " +
"be called an imaginary idea than a real object; and this being its " +
"nature it occupies no space. Therefore an infinite number of lines " +
"may be conceived of as intersecting each other at a point, which has " +
"no dimensions and is only of the thickness (if thickness it may be " +
"called) of one single line. " +
" " +
"HOW WE MAY CONCLUDE THAT A SUPERFICIES TERMINATES IN A POINT? " +
" " +
"An angular surface is reduced to a point where it terminates in an " +
"angle. Or, if the sides of that angle are produced in a straight " +
"line, then--beyond that angle--another surface is generated, " +
"smaller, or equal to, or larger than the first. " +
" " +
"48. " +
" " +
"OF DRAWING OUTLINE. " +
" " +
"Consider with the greatest care the form of the outlines of every " +
"object, and the character of their undulations. And these " +
"undulations must be separately studied, as to whether the curves are " +
"composed of arched convexities or angular concavities. " +
" " +
"49. " +
" " +
"The nature of the outline. " +
" " +
"The boundaries of bodies are the least of all things. The " +
"proposition is proved to be true, because the boundary of a thing is " +
"a surface, which is not part of the body contained within that " +
"surface; nor is it part of the air surrounding that body, but is the " +
"medium interposted between the air and the body, as is proved in its " +
"place. But the lateral boundaries of these bodies is the line " +
"forming the boundary of the surface, which line is of invisible " +
"thickness. Wherefore O painter! do not surround your bodies with " +
"lines, and above all when representing objects smaller than nature; " +
"for not only will their external outlines become indistinct, but " +
"their parts will be invisible from distance. " +
" " +
"50. " +
" " +
"Definition of Perspective. " +
" " +
"[Drawing is based upon perspective, which is nothing else than a " +
"thorough knowledge of the function of the eye. And this function " +
"simply consists in receiving in a pyramid the forms and colours of " +
"all the objects placed before it. I say in a pyramid, because there " +
"is no object so small that it will not be larger than the spot where " +
"these pyramids are received into the eye. Therefore, if you extend " +
"the lines from the edges of each body as they converge you will " +
"bring them to a single point, and necessarily the said lines must " +
"form a pyramid.] " +
" " +
"[Perspective is nothing more than a rational demonstration applied " +
"to the consideration of how objects in front of the eye transmit " +
"their image to it, by means of a pyramid of lines. The _Pyramid_ is " +
"the name I apply to the lines which, starting from the surface and " +
"edges of each object, converge from a distance and meet in a single " +
"point.] " +
" " +
"[Perspective is a rational demonstration, by which we may " +
"practically and clearly understand how objects transmit their own " +
"image, by lines forming a Pyramid (centred) in the eye.] " +
" " +
"Perspective is a rational demonstration by which experience confirms " +
"that every object sends its image to the eye by a pyramid of lines; " +
"and bodies of equal size will result in a pyramid of larger or " +
"smaller size, according to the difference in their distance, one " +
"from the other. By a pyramid of lines I mean those which start from " +
"the surface and edges of bodies, and, converging from a distance " +
"meet in a single point. A point is said to be that which [having no " +
"dimensions] cannot be divided, and this point placed in the eye " +
"receives all the points of the cone. " +
" " +
"[Footnote: 50. 1-5. Compare with this the Proem. No. 21. The " +
"paragraphs placed in brackets: lines 1-9, 10-14, and 17--20, are " +
"evidently mere sketches and, as such, were cancelled by the writer; " +
"but they serve as a commentary on the final paragraph, lines 22-29.] " +
" " +
"51. " +
" " +
"IN WHAT WAY THE EYE SEES OBJECTS PLACED IN FRONT OF IT. " +
" " +
"The perception of the object depends on the direction of the eye. " +
" " +
"Supposing that the ball figured above is the ball of the eye and let " +
"the small portion of the ball which is cut off by the line _s t_ be " +
"the pupil and all the objects mirrored on the centre of the face of " +
"the eye, by means of the pupil, pass on at once and enter the pupil, " +
"passing through the crystalline humour, which does not interfere in " +
"the pupil with the things seen by means of the light. And the pupil " +
"having received the objects, by means of the light, immediately " +
"refers them and transmits them to the intellect by the line _a b_. " +
"And you must know that the pupil transmits nothing perfectly to the " +
"intellect or common sense excepting when the objects presented to it " +
"by means of light, reach it by the line _a b;_ as, for instance, by " +
"the line _b c_. For although the lines _m n_ and _f g_ may be seen " +
"by the pupil they are not perfectly taken in, because they do not " +
"coincide with the line _a b_. And the proof is this: If the eye, " +
"shown above, wants to count the letters placed in front, the eye " +
"will be obliged to turn from letter to letter, because it cannot " +
"discern them unless they lie in the line _a b;_ as, for instance, in " +
"the line _a c_. All visible objects reach the eye by the lines of a " +
"pyramid, and the point of the pyramid is the apex and centre of it, " +
"in the centre of the pupil, as figured above. " +
" " +
"[Footnote: 51. In this problem the eye is conceived of as fixed and " +
"immovable; this is plain from line 11.] " +
" " +
"Experimental proof of the existence of the pyramid of sight (52-55). " +
" " +
"52. " +
" " +
"Perspective is a rational demonstration, confirmed by experience, " +
"that all objects transmit their image to the eye by a pyramid of " +
"lines. " +
" " +
"By a pyramid of lines I understand those lines which start from the " +
"edges of the surface of bodies, and converging from a distance, meet " +
"in a single point; and this point, in the present instance, I will " +
"show to be situated in the eye which is the universal judge of all " +
"objects. By a point I mean that which cannot be divided into parts; " +
"therefore this point, which is situated in the eye, being " +
"indivisible, no body is seen by the eye, that is not larger than " +
"this point. This being the case it is inevitable that the lines " +
"which come from the object to the point must form a pyramid. And if " +
"any man seeks to prove that the sense of sight does not reside in " +
"this point, but rather in the black spot which is visible in the " +
"middle of the pupil, I might reply to him that a small object could " +
"never diminish at any distance, as it might be a grain of millet or " +
"of oats or of some similar thing, and that object, if it were larger " +
"than the said [black] spot would never be seen as a whole; as may be " +
"seen in the diagram below. Let _a_. be the seat of sight, _b e_ the " +
"lines which reach the eye. Let _e d_ be the grains of millet within " +
"these lines. You plainly see that these will never diminish by " +
"distance, and that the body _m n_ could not be entirely covered by " +
"it. Therefore you must confess that the eye contains within itself " +
"one single indivisible point _a_, to which all the points converge " +
"of the pyramid of lines starting from an object, as is shown below. " +
"Let _a_. _b_. be the eye; in the centre of it is the point above " +
"mentioned. If the line _e f_ is to enter as an image into so small " +
"an opening in the eye, you must confess that the smaller object " +
"cannot enter into what is smaller than itself unless it is " +
"diminished, and by diminishing it must take the form of a pyramid. " +
" " +
"53. " +
" " +
"PERSPECTIVE. " +
" " +
"Perspective comes in where judgment fails [as to the distance] in " +
"objects which diminish. The eye can never be a true judge for " +
"determining with exactitude how near one object is to another which " +
"is equal to it [in size], if the top of that other is on the level " +
"of the eye which sees them on that side, excepting by means of the " +
"vertical plane which is the standard and guide of perspective. Let " +
"_n_ be the eye, _e f_ the vertical plane above mentioned. Let _a b c " +
"d_ be the three divisions, one below the other; if the lines _a n_ " +
"and _c n_ are of a given length and the eye _n_ is in the centre, " +
"then _a b_ will look as large as _b c. c d_ is lower and farther off " +
"from _n_, therefore it will look smaller. And the same effect will " +
"appear in the three divisions of a face when the eye of the painter " +
"who is drawing it is on a level with the eye of the person he is " +
"painting. " +
" " +
"54. " +
" " +
"TO PROVE HOW OBJECTS REACH THE EYE. " +
" " +
"If you look at the sun or some other luminous body and then shut " +
"your eyes you will see it again inside your eye for a long time. " +
"This is evidence that images enter into the eye. " +
" " +
"The relations of the distance points to the vanishing point (55-56). " +
" " +
"55. " +
" " +
"ELEMENTS OF PERSPECTIVE. " +
" " +
"All objects transmit their image to the eye in pyramids, and the " +
"nearer to the eye these pyramids are intersected the smaller will " +
"the image appear of the objects which cause them. Therefore, you may " +
"intersect the pyramid with a vertical plane [Footnote 4: _Pariete_. " +
"Compare the definitions in 85, 2-5, 6-27. These lines refer " +
"exclusively to the third diagram. For the better understanding of " +
"this it should be observed that _c s_ must be regarded as " +
"representing the section or profile of a square plane, placed " +
"horizontally (comp. lines 11, 14, 17) for which the word _pianura_ " +
"is subsequently employed (20, 22). Lines 6-13 contain certain " +
"preliminary observations to guide the reader in understanding the " +
"diagram; the last three seem to have been added as a supplement. " +
"Leonardo's mistake in writing _t denota_ (line 6) for _f denota_ has " +
"been rectified.] which reaches the base of the pyramid as is shown " +
"in the plane _a n_. " +
" " +
"The eye _f_ and the eye _t_ are one and the same thing; but the eye " +
"_f_ marks the distance, that is to say how far you are standing from " +
"the object; and the eye _t_ shows you the direction of it; that is " +
"whether you are opposite, or on one side, or at an angle to the " +
"object you are looking at. And remember that the eye _f_ and the eye " +
"_t_ must always be kept on the same level. For example if you raise " +
"or lower the eye from the distance point _f_ you must do the same " +
"with the direction point _t_. And if the point _f_ shows how far the " +
"eye is distant from the square plane but does not show on which side " +
"it is placed--and, if in the same way, the point _t_ show _s_ the " +
"direction and not the distance, in order to ascertain both you must " +
"use both points and they will be one and the same thing. If the eye " +
"_f_ could see a perfect square of which all the sides were equal to " +
"the distance between _s_ and _c_, and if at the nearest end of the " +
"side towards the eye a pole were placed, or some other straight " +
"object, set up by a perpendicular line as shown at _r s_--then, I " +
"say, that if you were to look at the side of the square that is " +
"nearest to you it will appear at the bottom of the vertical plane _r " +
"s_, and then look at the farther side and it would appear to you at " +
"the height of the point _n_ on the vertical plane. Thus, by this " +
"example, you can understand that if the eye is above a number of " +
"objects all placed on the same level, one beyond another, the more " +
"remote they are the higher they will seem, up to the level of the " +
"eye, but no higher; because objects placed upon the level on which " +
"your feet stand, so long as it is flat--even if it be extended into " +
"infinity--would never be seen above the eye; since the eye has in " +
"itself the point towards which all the cones tend and converge which " +
"convey the images of the objects to the eye. And this point always " +
"coincides with the point of diminution which is the extreme of all " +
"we can see. And from the base line of the first pyramid as far as " +
"the diminishing point " +
" " +
"[Footnote: The two diagrams above the chapter are explained by the " +
"first five lines. They have, however, more letters than are referred " +
"to in the text, a circumstance we frequently find occasion to " +
"remark.] " +
" " +
"56. " +
" " +
"there are only bases without pyramids which constantly diminish up " +
"to this point. And from the first base where the vertical plane is " +
"placed towards the point in the eye there will be only pyramids " +
"without bases; as shown in the example given above. Now, let _a b_ " +
"be the said vertical plane and _r_ the point of the pyramid " +
"terminating in the eye, and _n_ the point of diminution which is " +
"always in a straight line opposite the eye and always moves as the " +
"eye moves--just as when a rod is moved its shadow moves, and moves " +
"with it, precisely as the shadow moves with a body. And each point " +
"is the apex of a pyramid, all having a common base with the " +
"intervening vertical plane. But although their bases are equal their " +
"angles are not equal, because the diminishing point is the " +
"termination of a smaller angle than that of the eye. If you ask me: " +
"\"By what practical experience can you show me these points?\" I " +
"reply--so far as concerns the diminishing point which moves with you " +
"--when you walk by a ploughed field look at the straight furrows " +
"which come down with their ends to the path where you are walking, " +
"and you will see that each pair of furrows will look as though they " +
"tried to get nearer and meet at the [farther] end. " +
" " +
"[Footnote: For the easier understanding of the diagram and of its " +
"connection with the preceding I may here remark that the square " +
"plane shown above in profile by the line _c s_ is here indicated by " +
"_e d o p_. According to lines 1, 3 _a b_ must be imagined as a plane " +
"of glass placed perpendicularly at _o p_.] " +
" " +
"57. " +
" " +
"How to measure the pyramid of vision. " +
" " +
"As regards the point in the eye; it is made more intelligible by " +
"this: If you look into the eye of another person you will see your " +
"own image. Now imagine 2 lines starting from your ears and going to " +
"the ears of that image which you see in the other man's eye; you " +
"will understand that these lines converge in such a way that they " +
"would meet in a point a little way beyond your own image mirrored in " +
"the eye. And if you want to measure the diminution of the pyramid in " +
"the air which occupies the space between the object seen and the " +
"eye, you must do it according to the diagram figured below. Let _m " +
"n_ be a tower, and _e f_ a, rod, which you must move backwards and " +
"forwards till its ends correspond with those of the tower [Footnote " +
"9: _I sua stremi .. della storre_ (its ends ... of the tower) this " +
"is the case at _e f_.]; then bring it nearer to the eye, at _c d_ " +
"and you will see that the image of the tower seems smaller, as at _r " +
"o_. Then [again] bring it closer to the eye and you will see the rod " +
"project far beyond the image of the tower from _a_ to _b_ and from " +
"_t_ to _b_, and so you will discern that, a little farther within, " +
"the lines must converge in a point. " +
" " +
"The Production of pyramid of Vision (58-60). " +
" " +
"58. " +
" " +
"PERSPECTIVE. " +
" " +
"The instant the atmosphere is illuminated it will be filled with an " +
"infinite number of images which are produced by the various bodies " +
"and colours assembled in it. And the eye is the target, a loadstone, " +
"of these images. " +
" " +
"59. " +
" " +
"The whole surface of opaque bodies displays its whole image in all " +
"the illuminated atmosphere which surrounds them on all sides. " +
" " +
"60. " +
" " +
"That the atmosphere attracts to itself, like a loadstone, all the " +
"images of the objects that exist in it, and not their forms merely " +
"but their nature may be clearly seen by the sun, which is a hot and " +
"luminous body. All the atmosphere, which is the all-pervading " +
"matter, absorbs light and heat, and reflects in itself the image of " +
"the source of that heat and splendour and, in each minutest portion, " +
"does the same. The Northpole does the same as the loadstone shows; " +
"and the moon and the other planets, without suffering any " +
"diminution, do the same. Among terrestrial things musk does the same " +
"and other perfumes. " +
" " +
"61. " +
" " +
"All bodies together, and each by itself, give off to the surrounding " +
"air an infinite number of images which are all-pervading and each " +
"complete, each conveying the nature, colour and form of the body " +
"which produces it. " +
" " +
"It can clearly be shown that all bodies are, by their images, " +
"all-pervading in the surrounding atmosphere, and each complete in " +
"itself as to substance form and colour; this is seen by the images " +
"of the various bodies which are reproduced in one single perforation " +
"through which they transmit the objects by lines which intersect and " +
"cause reversed pyramids, from the objects, so that they are upside " +
"down on the dark plane where they are first reflected. The reason of " +
"this is-- " +
" " +
"[Footnote: The diagram intended to illustrate the statement (Pl. II " +
"No. i) occurs in the original between lines 3 and 4. The three " +
"circles must be understood to represent three luminous bodies which " +
"transmit their images through perforations in a wall into a dark " +
"chamber, according to a law which is more fully explained in 75?81. " +
"So far as concerns the present passage the diagram is only intended " +
"to explain that the images of the three bodies may be made to " +
"coalesce at any given spot. In the circles are written, " +
"giallo--yellow, biï¿½cho--white, rosso--red. " +
" " +
"The text breaks off at line 8. The paragraph No.40 follows here in " +
"the original MS.] " +
" " +
"62. " +
" " +
"Every point is the termination of an infinite number of lines, which " +
"diverge to form a base, and immediately, from the base the same " +
"lines converge to a pyramid [imaging] both the colour and form. No " +
"sooner is a form created or compounded than suddenly infinite lines " +
"and angles are produced from it; and these lines, distributing " +
"themselves and intersecting each other in the air, give rise to an " +
"infinite number of angles opposite to each other. Given a base, each " +
"opposite angle, will form a triangle having a form and proportion " +
"equal to the larger angle; and if the base goes twice into each of " +
"the 2 lines of the pyramid the smaller triangle will do the same. " +
" " +
"63. " +
" " +
"Every body in light and shade fills the surrounding air with " +
"infinite images of itself; and these, by infinite pyramids diffused " +
"in the air, represent this body throughout space and on every side. " +
"Each pyramid that is composed of a long assemblage of rays includes " +
"within itself an infinite number of pyramids and each has the same " +
"power as all, and all as each. A circle of equidistant pyramids of " +
"vision will give to their object angles of equal size; and an eye at " +
"each point will see the object of the same size. The body of the " +
"atmosphere is full of infinite pyramids composed of radiating " +
"straight lines, which are produced from the surface of the bodies in " +
"light and shade, existing in the air; and the farther they are from " +
"the object which produces them the more acute they become and " +
"although in their distribution they intersect and cross they never " +
"mingle together, but pass through all the surrounding air, " +
"independently converging, spreading, and diffused. And they are all " +
"of equal power [and value]; all equal to each, and each equal to " +
"all. By these the images of objects are transmitted through all " +
"space and in every direction, and each pyramid, in itself, includes, " +
"in each minutest part, the whole form of the body causing it. " +
" " +
"64. " +
" " +
"The body of the atmosphere is full of infinite radiating pyramids " +
"produced by the objects existing in it. These intersect and cross " +
"each other with independent convergence without interfering with " +
"each other and pass through all the surrounding atmosphere; and are " +
"of equal force and value--all being equal to each, each to all. And " +
"by means of these, images of the body are transmitted everywhere and " +
"on all sides, and each receives in itself every minutest portion of " +
"the object that produces it. " +
" " +
"Proof by experiment (65-66). " +
" " +
"65. " +
" " +
"PERSPECTIVE. " +
" " +
"The air is filled with endless images of the objects distributed in " +
"it; and all are represented in all, and all in one, and all in each, " +
"whence it happens that if two mirrors are placed in such a manner as " +
"to face each other exactly, the first will be reflected in the " +
"second and the second in the first. The first being reflected in the " +
"second takes to it the image of itself with all the images " +
"represented in it, among which is the image of the second mirror, " +
"and so, image within image, they go on to infinity in such a manner " +
"as that each mirror has within it a mirror, each smaller than the " +
"last and one inside the other. Thus, by this example, it is clearly " +
"proved that every object sends its image to every spot whence the " +
"object itself can be seen; and the converse: That the same object " +
"may receive in itself all the images of the objects that are in " +
"front of it. Hence the eye transmits through the atmosphere its own " +
"image to all the objects that are in front of it and receives them " +
"into itself, that is to say on its surface, whence they are taken in " +
"by the common sense, which considers them and if they are pleasing " +
"commits them to the memory. Whence I am of opinion: That the " +
"invisible images in the eyes are produced towards the object, as the " +
"image of the object to the eye. That the images of the objects must " +
"be disseminated through the air. An instance may be seen in several " +
"mirrors placed in a circle, which will reflect each other endlessly. " +
"When one has reached the other it is returned to the object that " +
"produced it, and thence--being diminished--it is returned again to " +
"the object and then comes back once more, and this happens " +
"endlessly. If you put a light between two flat mirrors with a " +
"distance of 1 braccio between them you will see in each of them an " +
"infinite number of lights, one smaller than another, to the last. If " +
"at night you put a light between the walls of a room, all the parts " +
"of that wall will be tinted with the image of that light. And they " +
"will receive the light and the light will fall on them, mutually, " +
"that is to say, when there is no obstacle to interrupt the " +
"transmission of the images. This same example is seen in a greater " +
"degree in the distribution of the solar rays which all together, and " +
"each by itself, convey to the object the image of the body which " +
"causes it. That each body by itself alone fills with its images the " +
"atmosphere around it, and that the same air is able, at the same " +
"time, to receive the images of the endless other objects which are " +
"in it, this is clearly proved by these examples. And every object is " +
"everywhere visible in the whole of the atmosphere, and the whole in " +
"every smallest part of it; and all the objects in the whole, and all " +
"in each smallest part; each in all and all in every part. " +
" " +
"66. " +
" " +
"The images of objects are all diffused through the atmosphere which " +
"receives them; and all on every side in it. To prove this, let _a c " +
"e_ be objects of which the images are admitted to a dark chamber by " +
"the small holes _n p_ and thrown upon the plane _f i_ opposite to " +
"these holes. As many images will be produced in the chamber on the " +
"plane as the number of the said holes. " +
" " +
"67. " +
" " +
"General conclusions. " +
" " +
"All objects project their whole image and likeness, diffused and " +
"mingled in the whole of the atmosphere, opposite to themselves. The " +
"image of every point of the bodily surface, exists in every part of " +
"the atmosphere. All the images of the objects are in every part of " +
"the atmosphere. The whole, and each part of the image of the " +
"atmosphere is [reflected] in each point of the surface of the bodies " +
"presented to it. Therefore both the part and the whole of the images " +
"of the objects exist, both in the whole and in the parts of the " +
"surface of these visible bodies. Whence we may evidently say that " +
"the image of each object exists, as a whole and in every part, in " +
"each part and in the whole interchangeably in every existing body. " +
"As is seen in two mirrors placed opposite to each other. " +
" " +
"68. " +
" " +
"That the contrary is impossible. " +
" " +
"It is impossible that the eye should project from itself, by visual " +
"rays, the visual virtue, since, as soon as it opens, that front " +
"portion [of the eye] which would give rise to this emanation would " +
"have to go forth to the object and this it could not do without " +
"time. And this being so, it could not travel so high as the sun in a " +
"month's time when the eye wanted to see it. And if it could reach " +
"the sun it would necessarily follow that it should perpetually " +
"remain in a continuous line from the eye to the sun and should " +
"always diverge in such a way as to form between the sun and the eye " +
"the base and the apex of a pyramid. This being the case, if the eye " +
"consisted of a million worlds, it would not prevent its being " +
"consumed in the projection of its virtue; and if this virtue would " +
"have to travel through the air as perfumes do, the winds would bent " +
"it and carry it into another place. But we do [in fact] see the mass " +
"of the sun with the same rapidity as [an object] at the distance of " +
"a braccio, and the power of sight is not disturbed by the blowing of " +
"the winds nor by any other accident. " +
" " +
"[Footnote: The view here refuted by Leonardo was maintained among " +
"others by Bramantino, Leonardo's Milanese contemporary. LOMAZZO " +
"writes as follows in his Trattato dell' Arte della pittura &c. " +
"(Milano 1584. Libr. V cp. XXI): Sovviemmi di aver giï¿½ letto in certi " +
"scritti alcune cose di Bramantino milanese, celebratissimo pittore, " +
"attenente alla prospettiva, le quali ho voluto riferire, e quasi " +
"intessere in questo luogo, affinchï¿½ sappiamo qual fosse l'opinione " +
"di cosi chiaro e famoso pittore intorno alla prospettiva . . Scrive " +
"Bramantino che la prospettiva ï¿½ una cosa che contrafï¿½ il naturale, e " +
"che ciï¿½ si fa in tre modi " +
" " +
"Circa il primo modo che si fa con ragione, per essere la cosa in " +
"poche parole conclusa da Bramantino in maniera che giudico non " +
"potersi dir meglio, contenendovi si tutta Parte del principio al " +
"fine, io riferirï¿½ per appunto le proprie parole sue (cp. XXII, Prima " +
"prospettiva di Bramantino). La prima prospettiva fa le cose di " +
"punto, e l'altra non mai, e la terza piï¿½ appresso. Adunque la prima " +
"si dimanda prospettiva, cioï¿½ ragione, la quale fa l'effetto dell' " +
"occhio, facendo crescere e calare secondo gli effetti degli occhi. " +
"Questo crescere e calare non procede della cosa propria, che in se " +
"per esser lontana, ovvero vicina, per quello effetto non puï¿½ " +
"crescere e sminuire, ma procede dagli effetti degli occhi, i quali " +
"sono piccioli, e perciï¿½ volendo vedere tanto gran cosa_, bisogna che " +
"mandino fuora la virtï¿½ visiva, _la quale si dilata in tanta " +
"larghezza, che piglia tutto quello che vuoi vedere, ed_ arrivando a " +
"quella cosa la vede dove ï¿½: _e da lei agli occhi per quello circuito " +
"fino all' occhio, e tutto quello termine ï¿½ pieno di quella cosa_. " +
" " +
"It is worthy of note that Leonardo had made his memorandum refuting " +
"this view, at Milan in 1492] " +
" " +
"69. " +
" " +
"A parallel case. " +
" " +
"Just as a stone flung into the water becomes the centre and cause of " +
"many circles, and as sound diffuses itself in circles in the air: so " +
"any object, placed in the luminous atmosphere, diffuses itself in " +
"circles, and fills the surrounding air with infinite images of " +
"itself. And is repeated, the whole every-where, and the whole in " +
"every smallest part. This can be proved by experiment, since if you " +
"shut a window that faces west and make a hole [Footnote: 6. Here the " +
"text breaks off.] . . " +
" " +
"[Footnote: Compare LIBRI, _Histoire des sciences mathï¿½matiques en " +
"Italie_. Tome III, p. 43.] " +
" " +
"The function of the eye as explained by the camera obscura (70. 71). " +
" " +
"70. " +
" " +
"If the object in front of the eye sends its image to the eye, the " +
"eye, on the other hand, sends its image to the object, and no " +
"portion whatever of the object is lost in the images it throws off, " +
"for any reason either in the eye or the object. Therefore we may " +
"rather believe it to be the nature and potency of our luminous " +
"atmosphere which absorbs the images of the objects existing in it, " +
"than the nature of the objects, to send their images through the " +
"air. If the object opposite to the eye were to send its image to the " +
"eye, the eye would have to do the same to the object, whence it " +
"might seem that these images were an emanation. But, if so, it would " +
"be necessary [to admit] that every object became rapidly smaller; " +
"because each object appears by its images in the surrounding " +
"atmosphere. That is: the whole object in the whole atmosphere, and " +
"in each part; and all the objects in the whole atmosphere and all of " +
"them in each part; speaking of that atmosphere which is able to " +
"contain in itself the straight and radiating lines of the images " +
"projected by the objects. From this it seems necessary to admit that " +
"it is in the nature of the atmosphere, which subsists between the " +
"objects, and which attracts the images of things to itself like a " +
"loadstone, being placed between them. " +
" " +
"PROVE HOW ALL OBJECTS, PLACED IN ONE POSITION, ARE ALL EVERYWHERE " +
"AND ALL IN EACH PART. " +
" " +
"I say that if the front of a building--or any open piazza or " +
"field--which is illuminated by the sun has a dwelling opposite to " +
"it, and if, in the front which does not face the sun, you make a " +
"small round hole, all the illuminated objects will project their " +
"images through that hole and be visible inside the dwelling on the " +
"opposite wall which may be made white; and there, in fact, they will " +
"be upside down, and if you make similar openings in several places " +
"in the same wall you will have the same result from each. Hence the " +
"images of the illuminated objects are all everywhere on this wall " +
"and all in each minutest part of it. The reason, as we clearly know, " +
"is that this hole must admit some light to the said dwelling, and " +
"the light admitted by it is derived from one or many luminous " +
"bodies. If these bodies are of various colours and shapes the rays " +
"forming the images are of various colours and shapes, and so will " +
"the representations be on the wall. " +
" " +
"[Footnote: 70. 15--23. This section has already been published in the " +
"\"_Saggio delle Opere di Leonardo da Vinci_\" Milan 1872, pp. 13, 14. " +
"G. Govi observes upon it, that Leonardo is not to be regarded as the " +
"inventor of the Camera obscura, but that he was the first to explain " +
"by it the structure of the eye. An account of the Camera obscura " +
"first occurs in CESARE CESARINI's Italian version of Vitruvius, pub. " +
"1523, four years after Leonardo's death. Cesarini expressly names " +
"Benedettino Don Papnutio as the inventor of the Camera obscura. In " +
"his explanation of the function of the eye by a comparison with the " +
"Camera obscura Leonardo was the precursor of G. CARDANO, Professor " +
"of Medicine at Bologna (died 1576) and it appears highly probable " +
"that this is, in fact, the very discovery which Leonardo ascribes to " +
"himself in section 21 without giving any further details.] " +
" " +
"71. " +
" " +
"HOW THE IMAGES OF OBJECTS RECEIVED BY THE EYE INTERSECT WITHIN THE " +
"CRYSTALLINE HUMOUR OF THE EYE. " +
" " +
"An experiment, showing how objects transmit their images or " +
"pictures, intersecting within the eye in the crystalline humour, is " +
"seen when by some small round hole penetrate the images of " +
"illuminated objects into a very dark chamber. Then, receive these " +
"images on a white paper placed within this dark room and rather near " +
"to the hole and you will see all the objects on the paper in their " +
"proper forms and colours, but much smaller; and they will be upside " +
"down by reason of that very intersection. These images being " +
"transmitted from a place illuminated by the sun will seem actually " +
"painted on this paper which must be extremely thin and looked at " +
"from behind. And let the little perforation be made in a very thin " +
"plate of iron. Let _a b e d e_ be the object illuminated by the sun " +
"and _o r_ the front of the dark chamber in which is the said hole at " +
"_n m_. Let _s t_ be the sheet of paper intercepting the rays of the " +
"images of these objects upside down, because the rays being " +
"straight, _a_ on the right hand becomes _k_ on the left, and _e_ on " +
"the left becomes _f_ on the right; and the same takes place inside " +
"the pupil. " +
" " +
"[Footnote: This chapter is already known through a translation into " +
"French by VENTURI. Compare his '_Essai sur les ouvrages " +
"physico-mathï¿½matiques de L. da Vinci avec des fragments tirï¿½s de ses " +
"Manuscrits, apportï¿½s de l'Italie. Lu a la premiere classe de " +
"l'Institut national des Sciences et Arts.' Paris, An V_ (1797).] " +
" " +
"The practice of perspective (72. 73). " +
" " +
"72. " +
" " +
"In the practice of perspective the same rules apply to light and to " +
"the eye. " +
" " +
"73. " +
" " +
"The object which is opposite to the pupil of the eye is seen by that " +
"pupil and that which is opposite to the eye is seen by the pupil. " +
" " +
"Refraction of the rays falling upon the eye (74. 75) " +
" " +
"74. " +
" " +
"The lines sent forth by the image of an object to the eye do not " +
"reach the point within the eye in straight lines. " +
" " +
"75. " +
" " +
"If the judgment of the eye is situated within it, the straight lines " +
"of the images are refracted on its surface because they pass through " +
"the rarer to the denser medium. If, when you are under water, you " +
"look at objects in the air you will see them out of their true " +
"place; and the same with objects under water seen from the air. " +
" " +
"The intersection of the rays (76-82). " +
" " +
"76. " +
" " +
"The inversion of the images. " +
" " +
"All the images of objects which pass through a window [glass pane] " +
"from the free outer air to the air confined within walls, are seen " +
"on the opposite side; and an object which moves in the outer air " +
"from east to west will seem in its shadow, on the wall which is " +
"lighted by this confined air, to have an opposite motion. " +
" " +
"77. " +
" " +
"THE PRINCIPLE ON WHICH THE IMAGES OF BODIES PASS IN BETWEEN THE " +
"MARGINS OF THE OPENINGS BY WHICH THEY ENTER. " +
" " +
"What difference is there in the way in which images pass through " +
"narrow openings and through large openings, or in those which pass " +
"by the sides of shaded bodies? By moving the edges of the opening " +
"through which the images are admitted, the images of immovable " +
"objects are made to move. And this happens, as is shown in the 9th " +
"which demonstrates: [Footnote 11: _per la 9a che dicie_. When " +
"Leonardo refers thus to a number it serves to indicate marginal " +
"diagrams; this can in some instances be distinctly proved. The ninth " +
"sketch on the page W. L. 145 b corresponds to the middle sketch of " +
"the three reproduced.] the images of any object are all everywhere, " +
"and all in each part of the surrounding air. It follows that if one " +
"of the edges of the hole by which the images are admitted to a dark " +
"chamber is moved it cuts off those rays of the image that were in " +
"contact with it and gets nearer to other rays which previously were " +
"remote from it &c. " +
" " +
"OF THE MOVEMENT OF THE EDGE AT THE RIGHT OR LEFT, OR THE UPPER, OR " +
"LOWER EDGE. " +
" " +
"If you move the right side of the opening the image on the left will " +
"move [being that] of the object which entered on the right side of " +
"the opening; and the same result will happen with all the other " +
"sides of the opening. This can be proved by the 2nd of this which " +
"shows: all the rays which convey the images of objects through the " +
"air are straight lines. Hence, if the images of very large bodies " +
"have to pass through very small holes, and beyond these holes " +
"recover their large size, the lines must necessarily intersect. " +
" " +
"[Footnote: 77. 2. In the first of the three diagrams Leonardo had " +
"drawn only one of the two margins, et _m_.] " +
" " +
"78. " +
" " +
"Necessity has provided that all the images of objects in front of " +
"the eye shall intersect in two places. One of these intersections is " +
"in the pupil, the other in the crystalline lens; and if this were " +
"not the case the eye could not see so great a number of objects as " +
"it does. This can be proved, since all the lines which intersect do " +
"so in a point. Because nothing is seen of objects excepting their " +
"surface; and their edges are lines, in contradistinction to the " +
"definition of a surface. And each minute part of a line is equal to " +
"a point; for _smallest_ is said of that than which nothing can be " +
"smaller, and this definition is equivalent to the definition of the " +
"point. Hence it is possible for the whole circumference of a circle " +
"to transmit its image to the point of intersection, as is shown in " +
"the 4th of this which shows: all the smallest parts of the images " +
"cross each other without interfering with each other. These " +
"demonstrations are to illustrate the eye. No image, even of the " +
"smallest object, enters the eye without being turned upside down; " +
"but as it penetrates into the crystalline lens it is once more " +
"reversed and thus the image is restored to the same position within " +
"the eye as that of the object outside the eye. " +
" " +
"79. " +
" " +
"OF THE CENTRAL LINE OF THE EYE. " +
" " +
"Only one line of the image, of all those that reach the visual " +
"virtue, has no intersection; and this has no sensible dimensions " +
"because it is a mathematical line which originates from a " +
"mathematical point, which has no dimensions. " +
" " +
"According to my adversary, necessity requires that the central line " +
"of every image that enters by small and narrow openings into a dark " +
"chamber shall be turned upside down, together with the images of the " +
"bodies that surround it. " +
" " +
"80. " +
" " +
"AS TO WHETHER THE CENTRAL LINE OF THE IMAGE CAN BE INTERSECTED, OR " +
"NOT, WITHIN THE OPENING. " +
" " +
"It is impossible that the line should intersect itself; that is, " +
"that its right should cross over to its left side, and so, its left " +
"side become its right side. Because such an intersection demands two " +
"lines, one from each side; for there can be no motion from right to " +
"left or from left to right in itself without such extension and " +
"thickness as admit of such motion. And if there is extension it is " +
"no longer a line but a surface, and we are investigating the " +
"properties of a line, and not of a surface. And as the line, having " +
"no centre of thickness cannot be divided, we must conclude that the " +
"line can have no sides to intersect each other. This is proved by " +
"the movement of the line _a f_ to _a b_ and of the line _e b_ to _e " +
"f_, which are the sides of the surface _a f e b_. But if you move " +
"the line _a b_ and the line _e f_, with the frontends _a e_, to the " +
"spot _c_, you will have moved the opposite ends _f b_ towards each " +
"other at the point _d_. And from the two lines you will have drawn " +
"the straight line _c d_ which cuts the middle of the intersection of " +
"these two lines at the point _n_ without any intersection. For, you " +
"imagine these two lines as having breadth, it is evident that by " +
"this motion the first will entirely cover the other--being equal " +
"with it--without any intersection, in the position _c d_. And this " +
"is sufficient to prove our proposition. " +
" " +
"81. " +
" " +
"HOW THE INNUMERABLE RAYS FROM INNUMERABLE IMAGES CAN CONVERGE TO A " +
"POINT. " +
" " +
"Just as all lines can meet at a point without interfering with each " +
"other--being without breadth or thickness--in the same way all the " +
"images of surfaces can meet there; and as each given point faces the " +
"object opposite to it and each object faces an opposite point, the " +
"converging rays of the image can pass through the point and diverge " +
"again beyond it to reproduce and re-magnify the real size of that " +
"image. But their impressions will appear reversed--as is shown in " +
"the first, above; where it is said that every image intersects as it " +
"enters the narrow openings made in a very thin substance. " +
" " +
"Read the marginal text on the other side. " +
" " +
"In proportion as the opening is smaller than the shaded body, so " +
"much less will the images transmitted through this opening intersect " +
"each other. The sides of images which pass through openings into a " +
"dark room intersect at a point which is nearer to the opening in " +
"proportion as the opening is narrower. To prove this let _a b_ be an " +
"object in light and shade which sends not its shadow but the image " +
"of its darkened form through the opening _d e_ which is as wide as " +
"this shaded body; and its sides _a b_, being straight lines (as has " +
"been proved) must intersect between the shaded object and the " +
"opening; but nearer to the opening in proportion as it is smaller " +
"than the object in shade. As is shown, on your right hand and your " +
"left hand, in the two diagrams _a_ _b_ _c_ _n_ _m_ _o_ where, the " +
"right opening _d_ _e_, being equal in width to the shaded object _a_ " +
"_b_, the intersection of the sides of the said shaded object occurs " +
"half way between the opening and the shaded object at the point _c_. " +
"But this cannot happen in the left hand figure, the opening _o_ " +
"being much smaller than the shaded object _n_ _m_. " +
" " +
"It is impossible that the images of objects should be seen between " +
"the objects and the openings through which the images of these " +
"bodies are admitted; and this is plain, because where the atmosphere " +
"is illuminated these images are not formed visibly. " +
" " +
"When the images are made double by mutually crossing each other they " +
"are invariably doubly as dark in tone. To prove this let _d_ _e_ _h_ " +
"be such a doubling which although it is only seen within the space " +
"between the bodies in _b_ and _i_ this will not hinder its being " +
"seen from _f_ _g_ or from _f_ _m_; being composed of the images _a_ " +
"_b_ _i_ _k_ which run together in _d_ _e_ _h_. " +
" " +
"[Footnote: 81. On the original diagram at the beginning of this " +
"chapter Leonardo has written \"_azurro_\" (blue) where in the " +
"facsimile I have marked _A_, and \"_giallo_\" (yellow) where _B_ " +
"stands.] " +
" " +
"[Footnote: 15--23. These lines stand between the diagrams I and III.] " +
" " +
"[Footnote: 24--53. These lines stand between the diagrams I and II.] " +
" " +
"[Footnote: 54--97 are written along the left side of diagram I.] " +
" " +
"82. " +
" " +
"An experiment showing that though the pupil may not be moved from " +
"its position the objects seen by it may appear to move from their " +
"places. " +
" " +
"If you look at an object at some distance from you and which is " +
"below the eye, and fix both your eyes upon it and with one hand " +
"firmly hold the upper lid open while with the other you push up the " +
"under lid--still keeping your eyes fixed on the object gazed at--you " +
"will see that object double; one [image] remaining steady, and the " +
"other moving in a contrary direction to the pressure of your finger " +
"on the lower eyelid. How false the opinion is of those who say that " +
"this happens because the pupil of the eye is displaced from its " +
"position. " +
" " +
"How the above mentioned facts prove that the pupil acts upside down " +
"in seeing. " +
" " +
"[Footnote: 82. 14--17. The subject indicated by these two headings is " +
"fully discussed in the two chapters that follow them in the " +
"original; but it did not seem to me appropriate to include them " +
"here.] " +
" " +
"Demostration of perspective by means of a vertical glass plane " +
"(83-85). " +
" " +
"83. " +
" " +
"OF THE PLANE OF GLASS. " +
" " +
"Perspective is nothing else than seeing place [or objects] behind a " +
"plane of glass, quite transparent, on the surface of which the " +
"objects behind that glass are to be drawn. These can be traced in " +
"pyramids to the point in the eye, and these pyramids are intersected " +
"on the glass plane. " +
" " +
"84. " +
" " +
"Pictorial perspective can never make an object at the same distance, " +
"look of the same size as it appears to the eye. You see that the " +
"apex of the pyramid _f c d_ is as far from the object _c_ _d_ as the " +
"same point _f_ is from the object _a_ _b_; and yet _c_ _d_, which is " +
"the base made by the painter's point, is smaller than _a_ _b_ which " +
"is the base of the lines from the objects converging in the eye and " +
"refracted at _s_ _t_, the surface of the eye. This may be proved by " +
"experiment, by the lines of vision and then by the lines of the " +
"painter's plumbline by cutting the real lines of vision on one and " +
"the same plane and measuring on it one and the same object. " +
" " +
"85. " +
" " +
"PERSPECTIVE. " +
" " +
"The vertical plane is a perpendicular line, imagined as in front of " +
"the central point where the apex of the pyramids converge. And this " +
"plane bears the same relation to this point as a plane of glass " +
"would, through which you might see the various objects and draw them " +
"on it. And the objects thus drawn would be smaller than the " +
"originals, in proportion as the distance between the glass and the " +
"eye was smaller than that between the glass and the objects. " +
" " +
"PERSPECTIVE. " +
" " +
"The different converging pyramids produced by the objects, will " +
"show, on the plane, the various sizes and remoteness of the objects " +
"causing them. " +
" " +
"PERSPECTIVE. " +
" " +
"All those horizontal planes of which the extremes are met by " +
"perpendicular lines forming right angles, if they are of equal width " +
"the more they rise to the level of eye the less this is seen, and " +
"the more the eye is above them the more will their real width be " +
"seen. " +
" " +
"PERSPECTIVE. " +
" " +
"The farther a spherical body is from the eye the more you will see " +
"of it. " +
" " +
"The angle of sight varies with the distance (86-88) " +
" " +
"86. " +
" " +
"A simple and natural method; showing how objects appear to the eye " +
"without any other medium. " +
" " +
"The object that is nearest to the eye always seems larger than " +
"another of the same size at greater distance. The eye _m_, seeing " +
"the spaces _o v x_, hardly detects the difference between them, and " +
"the. reason of this is that it is close to them [Footnote 6: It is " +
"quite inconceivable to me why M. RAVAISSON, in a note to his French " +
"translation of this simple passage should have remarked: _Il est " +
"clair que c'est par erreur que Leonard a ï¿½crit_ per esser visino _au " +
"lieu de_ per non esser visino. (See his printed ed. of MS. A. p. " +
"38.)]; but if these spaces are marked on the vertical plane _n o_ " +
"the space _o v_ will be seen at _o r_, and in the same way the space " +
"_v x_ will appear at _r q_. And if you carry this out in any place " +
"where you can walk round, it will look out of proportion by reason " +
"of the great difference in the spaces _o r_ and _r q_. And this " +
"proceeds from the eye being so much below [near] the plane that the " +
"plane is foreshortened. Hence, if you wanted to carry it out, you " +
"would have [to arrange] to see the perspective through a single hole " +
"which must be at the point _m_, or else you must go to a distance of " +
"at least 3 times the height of the object you see. The plane _o p_ " +
"being always equally remote from the eye will reproduce the objects " +
"in a satisfactory way, so that they may be seen from place to place. " +
" " +
"87. " +
" " +
"How every large mass sends forth its images, which may diminish " +
"through infinity. " +
" " +
"The images of any large mass being infinitely divisible may be " +
"infinitely diminished. " +
" " +
"88. " +
" " +
"Objects of equal size, situated in various places, will be seen by " +
"different pyramids which will each be smaller in proportion as the " +
"object is farther off. " +
" " +
"89. " +
" " +
"Perspective, in dealing with distances, makes use of two opposite " +
"pyramids, one of which has its apex in the eye and the base as " +
"distant as the horizon. The other has the base towards the eye and " +
"the apex on the horizon. Now, the first includes the [visible] " +
"universe, embracing all the mass of the objects that lie in front of " +
"the eye; as it might be a vast landscape seen through a very small " +
"opening; for the more remote the objects are from the eye, the " +
"greater number can be seen through the opening, and thus the pyramid " +
"is constructed with the base on the horizon and the apex in the eye, " +
"as has been said. The second pyramid is extended to a spot which is " +
"smaller in proportion as it is farther from the eye; and this second " +
"perspective [= pyramid] results from the first. " +
" " +
"90. " +
" " +
"SIMPLE PERSPECTIVE. " +
" " +
"Simple perspective is that which is constructed by art on a vertical " +
"plane which is equally distant from the eye in every part. Complex " +
"perspective is that which is constructed on a ground-plan in which " +
"none of the parts are equally distant from the eye. " +
" " +
"91. " +
" " +
"PERSPECTIVE. " +
" " +
"No surface can be seen exactly as it is, if the eye that sees it is " +
"not equally remote from all its edges. " +
" " +
"92. " +
" " +
"WHY WHEN AN OBJECT IS PLACED CLOSE TO THE EYE ITS EDGES ARE " +
"INDISTINCT. " +
" " +
"When an object opposite the eye is brought too close to it, its " +
"edges must become too confused to be distinguished; as it happens " +
"with objects close to a light, which cast a large and indistinct " +
"shadow, so is it with an eye which estimates objects opposite to it; " +
"in all cases of linear perspective, the eye acts in the same way as " +
"the light. And the reason is that the eye has one leading line (of " +
"vision) which dilates with distance and embraces with true " +
"discernment large objects at a distance as well as small ones that " +
"are close. But since the eye sends out a multitude of lines which " +
"surround this chief central one and since these which are farthest " +
"from the centre in this cone of lines are less able to discern with " +
"accuracy, it follows that an object brought close to the eye is not " +
"at a due distance, but is too near for the central line to be able " +
"to discern the outlines of the object. So the edges fall within the " +
"lines of weaker discerning power, and these are to the function of " +
"the eye like dogs in the chase which can put up the game but cannot " +
"take it. Thus these cannot take in the objects, but induce the " +
"central line of sight to turn upon them, when they have put them up. " +
"Hence the objects which are seen with these lines of sight have " +
"confused outlines. " +
" " +
"The relative size of objects with regard to their distance from the " +
"eye (93-98). " +
" " +
"93. " +
" " +
"PERSPECTIVE. " +
" " +
"Small objects close at hand and large ones at a distance, being seen " +
"within equal angles, will appear of the same size. " +
" " +
"94. " +
" " +
"PERSPECTIVE. " +
" " +
"There is no object so large but that at a great distance from the " +
"eye it does not appear smaller than a smaller object near. " +
" " +
"95. " +
" " +
"Among objects of equal size that which is most remote from the eye " +
"will look the smallest. [Footnote: This axiom, sufficiently clear in " +
"itself, is in the original illustrated by a very large diagram, " +
"constructed like that here reproduced under No. 108. " +
" " +
"The same idea is repeated in C. A. I a; I a, stated as follows: " +
"_Infra le cose d'equal grandeza quella si dimostra di minor figura " +
"che sara piï¿½ distante dall' ochio_.--] " +
" " +
"96. " +
" " +
"Why an object is less distinct when brought near to the eye, and why " +
"with spectacles, or without the naked eye sees badly either close or " +
"far off [as the case may be]. " +
" " +
"97. " +
" " +
"PERSPECTIVE. " +
" " +
"Among objects of equal size, that which is most remote from the eye " +
"will look the smallest. " +
" " +
"98. " +
" " +
"PERSPECTIVE. " +
" " +
"No second object can be so much lower than the first as that the eye " +
"will not see it higher than the first, if the eye is above the " +
"second. " +
" " +
"PERSPECTIVE. " +
" " +
"And this second object will never be so much higher than the first " +
"as that the eye, being below them, will not see the second as lower " +
"than the first. " +
" " +
"PERSPECTIVE. " +
" " +
"If the eye sees a second square through the centre of a smaller one, " +
"that is nearer, the second, larger square will appear to be " +
"surrounded by the smaller one. " +
" " +
"PERSPECTIVE--PROPOSITION. " +
" " +
"Objects that are farther off can never be so large but that those in " +
"front, though smaller, will conceal or surround them. " +
" " +
"DEFINITION. " +
" " +
"This proposition can be proved by experiment. For if you look " +
"through a small hole there is nothing so large that it cannot be " +
"seen through it and the object so seen appears surrounded and " +
"enclosed by the outline of the sides of the hole. And if you stop it " +
"up, this small stopping will conceal the view of the largest object. " +
" " +
"The apparent size of objects defined by calculation (99-105) " +
" " +
"99. " +
" " +
"OF LINEAR PERSPECTIVE. " +
" " +
"Linear Perspective deals with the action of the lines of sight, in " +
"proving by measurement how much smaller is a second object than the " +
"first, and how much the third is smaller than the second; and so on " +
"by degrees to the end of things visible. I find by experience that " +
"if a second object is as far beyond the first as the first is from " +
"the eye, although they are of the same size, the second will seem " +
"half the size of the first and if the third object is of the same " +
"size as the 2nd, and the 3rd is as far beyond the second as the 2nd " +
"from the first, it will appear of half the size of the second; and " +
"so on by degrees, at equal distances, the next farthest will be half " +
"the size of the former object. So long as the space does not exceed " +
"the length of 20 braccia. But, beyond 20 braccia figures of equal " +
"size will lose 2/4 and at 40 braccia they will lose 9/10, and 19/20 " +
"at 60 braccia, and so on diminishing by degrees. This is if the " +
"picture plane is distant from you twice your own height. If it is " +
"only as far off as your own height, there will be a great difference " +
"between the first braccia and the second. " +
" " +
"[Footnote: This chapter is included in DUFRESNE'S and MANZI'S " +
"editions of the Treatise on Painting. H. LUDWIG, in his commentary, " +
"calls this chapter \"_eines der wichtigsten im ganzen Tractat_\", but " +
"at the same time he asserts that its substance has been so " +
"completely disfigured in the best MS. copies that we ought not to " +
"regard Leonardo as responsible for it. However, in the case of this " +
"chapter, the old MS. copies agree with the original as it is " +
"reproduced above. From the chapters given later in this edition, " +
"which were written at a subsequent date, it would appear that " +
"Leonardo corrected himself on these points.] " +
" " +
"100. " +
" " +
"OF THE DIMINUTION OF OBJECTS AT VARIOUS DISTANCES. " +
" " +
"A second object as far distant from the first as the first is from " +
"the eye will appear half the size of the first, though they be of " +
"the same size really. " +
" " +
"OF THE DEGREES OF DIMINUTION. " +
" " +
"If you place the vertical plane at one braccio from the eye, the " +
"first object, being at a distance of 4 braccia from your eye will " +
"diminish to 3/4 of its height at that plane; and if it is 8 braccia " +
"from the eye, to 7/8; and if it is 16 braccia off, it will diminish " +
"to 15/16 of its height and so on by degrees, as the space doubles " +
"the diminution will double. ";




    }
}
