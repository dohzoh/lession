<?php

namespace current;

/**
 * Created by IntelliJ IDEA.
 * User: dozo
 * Date: 2016/03/05
 * Time: 9:32
 */
class ArrayObject extends \ArrayObject
{
    public function __construct($column = '', $input = [], $flags = 0, $iterator_class = 'ArrayIterator')
    {
        $sorted = [];

        $keys = array_keys($input);
        if($column === 'various5'){
            natcasesort($keys);
        }

        foreach($keys as $current)
        {
            if($column === 'various5')
                $url =$this->getUrl($current);
            else
                $url =$this->getUrl($input[$current]);

            $sorted[] = [
                'name' => $current,
                'count' => $input[$current],
                'url' => $url,
            ];
        }

        parent::__construct($sorted, $flags, $iterator_class);
    }

    public function getUrl($keyword)
    {
        $url = 'http://example.com/?';
        $url = $url. http_build_query(['keyword'=>$keyword]);
        return $url;
    }
}


$various5 = [
    '3 食戟のソーマ 17 (ジャンプコミックスDIGITAL) [Kindle版]' => 32,
    '1 アンゴルモア 元寇合戦記(5)<アンゴルモア 元寇合戦記> (角川コミックス・エース) [Kindle版]' => 23,
    '2 三国志F　１巻' => 45,
    '4 人狼ゲーム（１） (バンブーコミックス)' => 21,
];

$ids = [
    '3 食戟のソーマ 17 (ジャンプコミックスDIGITAL) [Kindle版]' => 'B01AU16PTS',
    '1 アンゴルモア 元寇合戦記(5)<アンゴルモア 元寇合戦記> (角川コミックス・エース) [Kindle版]' =>'B01BXR1368',
    '2 三国志F　１巻' =>'B00ZFE90EI',
    '4 人狼ゲーム（１） (バンブーコミックス)' =>'B00LHACXX4'
];

$obj = new ArrayObject('various5', $various5);
var_export($obj);
$obj = new ArrayObject('ids', $ids);
var_export($obj);

