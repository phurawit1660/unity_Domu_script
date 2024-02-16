﻿using UnityEngine;

public class Wish : MonoBehaviour
{
    public static string[] wishLove = new string[]
   {
        //ความรักแบบโรแมนติก
    "ภาพนี้คุณจะมีความรักอย่างหวานใจและสวยงาม",//index 0
    "ภาพนี้จะเน้นทางอารมณ์และความหลงใหล่ชอบพูดเรื่องราวเกี่ยวกับความรัก",//index 1
    "ภาพนี้ของคุณจะมีความอบอุ่นและความสงบ ๆชอบอยู่กับคู่รักแบบส่วนตัว",//index 2
        //ความรักแบบใกล้ชิด
    "ภาพนี้จะทำให้คุณกับเพื่อนสนิทกันมากขึ้นและเพื่อนก็จะสนใจคุณมากขึ้น",//index 3
    "เมื่อคุณใช้ภาพๆนี้ ชีวิตของคุณภายในครอบครัวจะมีความสุข มีความอบอุ่นขึ้น จากหน้ามือเป็นหลังมือ และจะทำให้ความสัมพันธ์ในครอบครัวแน่นแฟ้นมากยิ่งขึ้น",//index 4
    "ภาพนี้จะช้วยให้ชีวิตคู่ของคุณมีความสุขและจะทำให้ความรักของคุณเติบโตยิ้งขึ้น",//index 5
        //ความรักแบบหลงใหล
    "ภาพนี้จะทำให้ความรักของคุณดูมีความสดใสและมีชัวิตชีวามาก",//index 6
    "ภาพนี้จะทำให้ความรักของคุณมีความตื่นเต้นกับความรักของคุณ",//index 7
    "ภาพนี้จะทำให้ความรักของคุณเหมื่อนมีเพื่อนและคนรักที่พร้อมจะผ่านช่วงเวลาไปด้วยกัน"//index 8
   };

    public static string[] wishHealty = new string[]
   {
        //สุขภาพทางกาย
    "สำหรับคุณที่สุขภาพแข็งแรงดีมากอยู่แล้วลองใช้ภาพนี้ดูสิจะทำให้คุณแข็งแรงยิ่งขึ้นไปอีกและไม่เจ็บไข้ได้ป่วย",//index 0
    "ภาพนี้ทำให้สุขภาพร่างกายของคุณ มีความแข็งแรงมากว่าเดิม",//index 1
    "ถ้าหากใช้ภาพนี้จะทำคุณแข็งแรงยิ่งขึ้นนะ ถ้าหากป่วยจะก็หายเร็ว สุขภาพร่างกายกลับมาแข็งแรงเหมือนเดิม",//index 2
        //สุขภาพจิต
    "ถ้าคุณที่มีสุขภาพจิตที่ดีมากอยู่แล้วลองใช้ภาพนี้ดูสิจะไม่มีอะไรมากวนใจคุณแน่นอน",//index 3
    "ถ้าคุณใช้ภาพนี้คุณจะมีสิ่งดีๆเข้ามาจะไม่มีอะไรมาทำให้คุณจิตตกได้",//index 4
    "ลองให้ภาพนี้ดูสิจะทำให้คุณไม่เจอแต่อะไรแย่ๆที่ทำให้คุณรู้สึกไม่ดีและจะมีแต่ความสุขเข้ามาให้คุณรู้สึกดีขึ้นแน่นอน",//index 5
        //สุขภาพทางสังคม
    "ถ้าคุณใช้ภาพนี้จะไม่มีอะไรมากวนใจคุณและจะไม่มีคนแย่ๆเข้ามาทำให้รู้สึกไม่ดี",//index 6
    "ลองใช้ภาพนี้ดูสิจะมีคนสนับสนุนให้คุณดีขึ้นกว่าเดิมแน่นอนและจะทำใหคุณมีสังคมที่ดีเพิ่มขึ่นอีกด้วย",//index 7
    "ถ้าคุณใช้ภาพนี้จะมีคนมาสนับสุนคุณมากขึ้นแน่นอนและคนที่นิสัยดีและทัศนคติดีเข้หาุณมากขึ้น"//index 8
   };

    public static string[] wishLuck = new string[]
  {
        //โชคของอนาคต
    "ภาพนี้จะทำให้อนาคตของคุณโชคดีเมื่อคุณออกไปใช้ชีวิตและลองทำสิ่งใหม่ๆและท้าทายตัวเองมันจะทำให้คุณเก่งขึ้น",//index 0
    "ภาพนี้จะทำให้อนาคตของคุณมีโอกาสโชคดีในการรอโอกาสหากมีโอกาสก็ต้องคว้าโอกาสเอาไว้มันจะช่วยให้บางสิ่งบางอย่างที่กำลังจะทำประสบความสำเร็จ",//index 1
 
        //โชคของวันนี้
    "ภาพนี้จะทำให้วันนี้ของคุณโชคดีเมื่อคุณคิดก่อนจะทำบางสิ่งบางอย่างและจะทำให้สิ่งที่คุณทำนั้นจะประสบความสําเร็จ",//index 2
    "ภาพนี้จะทำให้วันนี้ของคุณโชคดีเมื่อคุณลงมือทำบางสิ่งบางอย่างและคุณก็จะทำสิ่งนั้นได้ดีด้วยและก็มีโอกาสประสบความสำเร็จอีกด้วย",//index 3
  
        //โชคของวันพรุ่งนี้
    "ภาพนี้จะทำให้วันพรุ่งนี้ของคุณโชคดีเมื่อคุณเป็นคนชอบหาโอกาสและโอกาสนั้นก็จะมาหาคุณเอง",//index 4
    "ภาพนี้จะทำให้วันพรุ่งนี้ของคุณโชคดีเมื่อคุณมีโอกาสก็ต้องคว้าโอกาสเอาไว้และคุณต้องลงมือทำด้วยนะ",//index 5

  };

    public static string[] wishWork = new string[]
  {
        //การงานด้านธุรกิจ
    "เมื่อใช้งานภาพนี้จะทำให้ธุรกิจการให้บริการของคุณปังๆ ลูกชื่นชอบ อยากที่จะกลับมาใช้บริการอีก หรือ ลูกค้าที่เค้ามาใช้บริการใหม่ ก็จะเข้ามาเพิ่มมากขึ้นไปอีก",//index 0
    "เมื่อใช้งานภาพนี้จะทำให้การบริหารการจัดการไม่ว่าจะเป็นกับลูกน้องหรือการจัดการจัดการต่างๆ ก็ คุณภาพที่ดีขึ้น",//index 1
    "เมื่อใช้งานภาพนี้จะทำให้การลงทุนของคุณมีประสิทธิภาพมากยิ่งขึ้น ไม่ว่าจะเป็น การลงทุนในหุ้น หรือ การลงทุนในด้านธุรกิจต่าง จากที่ดีอยู่แล้วจะดียิ่งขึ้นไปอีก",//index 2
        //ธุรกิจส่วนตัว
    "เมื่อใช้งานภาพนี้จะทำให้จะช่วยทำให้ธุรกิจเฟรนไชส์ ของคุณไม่ว่าจะเพิ่งเริ่ม หรือ ทำอยู่แล้ว จะทำให้รายดี ปังๆ เฮงๆ  เจริณรุ่งเรืองมากขึ้น",//index 3
    "เมื่อใช้งานภาพนี้จะทำให้ธุรกิจด้านการออกแบบของคุณจะทำให้ลูกค้า ชื่นชอบในผลงานและมีโอกาสเข้ามาหลากหลายในธุรกิจของคุณ",//index 4
    "เมื่อใช้งานภาพนี้จะทำให้ธุรกิจฟรีแลนซ์ของคุณจะทำให้ลูกค้า ชื่นชอบในผลงานและมีโอกาสเข้ามาหลากหลายในธุรกิจของคุณ",//index 5
        //งานที่เกียวกับonline
    "เมื่อใช้งานภาพนี้จะทำให้สื่อของคุณมีผู้เข้ามาดูและติดตามจนป็นที่รู้จักในวงกว้างทำให้สื่อของคุณมีความน่าเชื่อถือมากขึ้น",//index 6
    "เมื่อใช้งานภาพนี้จะทำให้การทำธุรกิจออนไลน์ การค้าขายในโลกออนไลน์ของคุณ เจริณรุ่งเรือง เงินจะไหลมาเทมา รำรวยเงินทอง มั่งมีศรีสุข",//index 7
    
  };

    public static string[] wishMoney = new string[]
     {
        //ซื้อของ 
    "ภาพๆนี้จะทำให้ตอนคุณซื้อของคุณจะได้เจอของที่ถูกใจและราคาถูกหรืออาจจะได้รับส่วนลดที่โดนใจ",//index 0
   
        //เอาไปลงทุน
    "ภาพนี้จะทำให้การลงทุนของคุณมีประสิทธิภาพมากยิ่งขึ้น ไม่ว่าจะเป็น การลงทุนในหุ้น หรือ การลงทุนในด้านธุรกิจต่าง จากที่ดีอยู่แล้วจะดียิ่งขึ้นไปอีก",//index 1
        //ออมเงิน
    "ภาพๆนี้จะทำให้การออมเงินด้วยเงินสดของคุณเป็นไปได้อย่างราบรื่น ไม่มีเรื่องที่ต้องใช้เงินเกินจำเป็นเข้ามา",//index 2
    "ภาพๆนี้จะทำให้การออมเงินของคุณด้วย mobile bankingเป็นไปได้อย่างราบรื่น ไม่มีเรื่องที่ต้องใช้เงินเกินจำเป็นเข้ามา",//index 3

     };


















}
